using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    int score = 0;
    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.gameObject.tag == "Wall")
        {
            Debug.Log("GameOver");
            Destroy(this.gameObject);
        }

        if(other.gameObject.tag == "Win")
        {
            Debug.Log("Win");
        //    SceneManager.LoadScene("Level 2");
        }

        if(other.gameObject.tag == "Coin")
        {
            score = score + 10;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
   }
}
