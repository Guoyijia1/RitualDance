using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public ArduinoKey arduinoKey;

    public bool canBePressed;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        arduinoKey = GetComponent<ArduinoKey>();
    }

    // Update is called once per frame
    void Update()
    {

        //bool isApressed = arduinoKey.Apressed;

        /*
        int Apressed = arduinoKey.ApressedDetected;

        if (Apressed == 1)
        {
            Debug.Log("A press bool true");

            
        }
        */

        
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();
            }
        }
        
    }


    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
        }
    }

    
}
