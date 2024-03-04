using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMoving : MonoBehaviour
{
    public float moveGroundSpeed;
    public Rigidbody2D theGroundRB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theGroundRB.velocity = new Vector2(moveGroundSpeed, theGroundRB.velocity.y);
    }
}
