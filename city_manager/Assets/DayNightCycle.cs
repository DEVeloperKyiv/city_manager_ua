using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public int days;
    public float timer;
    public float day;
    [SerializeField] private Vector3 _rotation;
    private void Start()
    {
        timer = 0;
    }

    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
        day = 360 / _rotation.x;
        timer += Time.deltaTime;
        if(timer >= day)
        {
            timer = 0;
            days += 1;
        }
    }
}
