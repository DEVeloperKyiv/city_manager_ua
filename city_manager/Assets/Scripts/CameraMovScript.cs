using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovScript : MonoBehaviour
{
    float speed = .1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveX, 0, moveY) * speed;
        transform.position += moveDirection;
    }
}
