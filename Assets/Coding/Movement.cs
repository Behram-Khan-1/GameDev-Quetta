using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Vector 3 is a variable, which stores 3 values at at time
    //  (x,y,z)

    public float movementSpeed;
    public float jumpForce;
    // private float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

        movement(); //function call

        Jump();

    }

    void Jump()
    {
        //Jump Limit 
        if (gameObject.transform.position.y < 4)
        {
            // Jump Code
            if (Input.GetKey(KeyCode.Space))
            {
                gameObject.transform.position = new Vector3(
                    gameObject.transform.position.x,
                    gameObject.transform.position.y + jumpForce,
                    gameObject.transform.position.z
                );
            }
        }
    }

    void movement() //function made
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position =
            new Vector3(
            gameObject.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z + movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position =
            new Vector3(
            gameObject.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z - movementSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x + movementSpeed,
                gameObject.transform.position.y,
                gameObject.transform.position.z
            );
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(
                gameObject.transform.position.x - movementSpeed,
                gameObject.transform.position.y,
                gameObject.transform.position.z
            );
        }
    }

    //how to change public to private and its impact.  
}
