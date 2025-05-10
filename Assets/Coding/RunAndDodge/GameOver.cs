using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<PhysicsMovement>().score == 3)
            {
                Debug.Log("GameOver");

            }
            else
            {
                SceneManager.LoadScene("RunAndDodge");
            }
        }
    }
}
