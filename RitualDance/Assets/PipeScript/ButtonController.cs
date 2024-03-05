using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class ButtonController : MonoBehaviour
{
   

    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;




    private void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        
    }


    private void Update()
    {
        /*
        if (serialPort.IsOpen && serialPort.BytesToRead > 0)
        {
            // Read the message from the serial port
            string message = serialPort.ReadLine();

            // Check if the received message is "S"


            if (message.Trim() == "A")
            {
                theSR.sprite = pressedImage;

            }

            if (message.Trim() != "A")
            {
                theSR.sprite = defaultImage;

            }
            */


            
            if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage;
        }
            
        }
    

}

