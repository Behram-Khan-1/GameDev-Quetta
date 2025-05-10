using System.Collections;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    Rigidbody rigidbody;
    public float movementForce;
    public float RightForce;
    public float jumpForce;
    public int score;
    Animator animator;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
        
    }
    void Update()
    {
        rigidbody.AddForce(-gameObject.transform.forward * movementForce);
        movement();
       // jump();
    }


    void movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(-gameObject.transform.right * RightForce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(gameObject.transform.right * RightForce);
        }
    }

    void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        //    animator.SetTrigger("Jump"); Jump using SetTrigger
        animator.SetBool("JumpStart", true);
            StartCoroutine(WaitForSecondsForJump(0.5f));
            // rigidbody.AddForce(gameObject.transform.up * jumpForce, ForceMode.Impulse);
        }
    }

    IEnumerator WaitForSecondsForJump(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        rigidbody.AddForce(gameObject.transform.up * jumpForce, ForceMode.Impulse);
        animator.SetBool("JumpStart", false);
    }
}
