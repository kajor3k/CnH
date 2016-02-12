using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    float Speed = 5.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            moveDirection = new Vector3(0, 1, 0);
            move();
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection = new Vector3(0, -1, 0);
            move();
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection = new Vector3(-1, 0, 0);
            move();
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection = new Vector3(1, 0, 0);
            move();
        }
    }


    private void move()
    {
        transform.position += moveDirection * Speed * Time.deltaTime;
    }
}


