using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float RotationSpeed = 0.5f;
    public GameObject Player;
    public List<GameObject> coinUI;
    public AudioSource audioSource;
    public AudioClip coinCollection;
    
    // float rotation= 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotation = rotation + RotationSpeed;
        // gameObject.transform.rotation = Quaternion.Euler(90, 0, rotation);

        gameObject.transform.Rotate(new Vector3(0, 0,RotationSpeed));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           Player.GetComponent<PhysicsMovement>().score++;
           Debug.Log(Player.GetComponent<PhysicsMovement>().score);
           audioSource.clip = coinCollection;
           audioSource.Play();

        if( Player.GetComponent<PhysicsMovement>().score == 1 )
        coinUI[0].SetActive(true);

        if( Player.GetComponent<PhysicsMovement>().score == 2 )
        coinUI[1].SetActive(true);

        if( Player.GetComponent<PhysicsMovement>().score == 3 )
        coinUI[2].SetActive(true);

           Destroy(this.gameObject);
        }
    }
}
