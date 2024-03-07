using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.XR;

public class ArduinoKey : MonoBehaviour
{
   
    SerialPort serialPort;


    public AudioSource noteC;
    public AudioSource noteD;
    public AudioSource noteE;
    public AudioSource noteG;
    public AudioSource clap;


    public GameObject NoteC;
    public GameObject NoteD;
    public GameObject NoteE;
    public GameObject NoteG;


    public GameObject Anote;

    //public bool Apressed { get; private set; }
    public int ApressedDetected { get; private set; }


    void Start()
    {
        // Modify the port name and baud rate based on your Arduino configuration
        serialPort = new SerialPort("/dev/cu.usbmodem1401", 9600);
        serialPort.Open();

        //Apressed = false;
        ApressedDetected = 0;
    }


    void Update()
    {
        

        if (serialPort.IsOpen && serialPort.BytesToRead > 0)
        {
            // Read the message from the serial port
            string message = serialPort.ReadLine();

            // Check if the received message is "S"
            

            if (message.Trim() == "A")
            {
                //Debug.Log("A pressed");
                noteC.Play();
                NoteC.SetActive(true);

                // Apressed = true;
                ApressedDetected = 1;

                //CheckNote();


            }

            if (message.Trim() == "S")
            {
                //Debug.Log("S pressed");
                noteD.Play();
                NoteD.SetActive(true);
            }

            if (message.Trim() == "D")
            {
               // Debug.Log("D pressed");
                noteE.Play();
                NoteE.SetActive(true);
            }

            if (message.Trim() == "F")
            {
                //Debug.Log("F pressed");
                noteG.Play();
                NoteG.SetActive(true);
            }

            if (message.Trim() == "L")
            {
                //Debug.Log("L pressed");
                clap.Play();
            }


            

            if (message.Trim() != "A")
            {
                Debug.Log("A pressed");
               
                NoteC.SetActive(false);

                //Apressed = false;
                ApressedDetected = 0;

            }

            if (message.Trim() != "S")
            {
                Debug.Log("S pressed");
                
                NoteD.SetActive(false);
            }

            if (message.Trim() != "D")
            {
                Debug.Log("D pressed");
                
                NoteE.SetActive(false);
            }

            if (message.Trim() != "F")
            {
                Debug.Log("F pressed");
                
                NoteG.SetActive(false);
            }
            

            
        }

        
    }

    /*
    void CheckNote()
    {
        if (Apressed)
        {
            Anote = GameObject.Find("MusicGame/MovingLetterHold/Rythem/cp");
            Anote.SetActive(false);
        }
    }

   */
}