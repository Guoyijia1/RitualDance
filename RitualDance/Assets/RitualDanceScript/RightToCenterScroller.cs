using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightToCenterScroller : MonoBehaviour
{
    public float beatTempo;

    public bool hasStarted;


    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
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
            transform.position -= new Vector3( beatTempo * Time.deltaTime, 0f, 0f);//move from the right_press key S

            //transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);//move from the top_press key w


            //Vector3 movementDirection = new Vector3(1f, -1f, 0f).normalized;
            //transform.position += movementDirection * beatTempo * Time.deltaTime;//move from the top-left to bottom-right_press key A

           
            //Vector3 movementDirection = new Vector3(-1f, -1f, 0f).normalized;
            //transform.position += movementDirection * beatTempo * Time.deltaTime; ;//move from the top-left to bottom-right_press key D

        }
    }
}
