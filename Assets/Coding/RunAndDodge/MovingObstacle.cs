using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float newX = Mathf.PingPong(Time.time * speed, 8) - 4; //0 -> 4  
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
