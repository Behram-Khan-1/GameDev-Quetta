using UnityEngine;

public class PhysicsCollision : MonoBehaviour
{
    public ParticleSystem ps;
    
    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.gameObject.tag == "Obstacle")     
        {
            Debug.Log("GameOver");
            ps.Stop();
        }   
    }


}
