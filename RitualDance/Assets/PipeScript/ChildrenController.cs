using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildrenController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;

    public float jumpForce;

    private bool isGrounded;

    public Transform groundCheckPoint;

    public LayerMask whatIsGround;

    public bool hasStarted;

    public GameObject endCanvas;

    private bool isWaiting = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted)//if we haven't done anything yet
        {
            /*if (Input.anyKeyDown)
            {
                hasStarted = true;
            }*/
        }
        else
        {
            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);

            isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .5f, whatIsGround);

            if (Input.GetKeyDown(KeyCode.Space) && !isWaiting)
            {
                

                if (isGrounded)
                {
                    StartCoroutine(ExecuteDelayedCode());
                    //yield return new WaitForSecondsRealtime(1);
                    theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);

                }

            }

        }
            
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Trap")
        {
            endCanvas.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    IEnumerator ExecuteDelayedCode()
    {
        // Set the flag to indicate that we are waiting
        isWaiting = true;

        // Wait for 1 second
        yield return new WaitForSeconds(1.5f);

        // Code to execute after the delay
        Debug.Log("Delayed action executed.");

        // Reset the flag to indicate that we're no longer waiting
        isWaiting = false;
    }
}
