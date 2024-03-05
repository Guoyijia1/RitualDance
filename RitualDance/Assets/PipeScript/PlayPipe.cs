using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayPipe : MonoBehaviour
{

    public AudioSource noteC;
    public AudioSource noteD;
    public AudioSource noteE;
    public AudioSource noteG;
    public AudioSource clap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            noteC.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            noteD.Play();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            noteE.Play();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            noteG.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            clap.Play();
        }
    }
}
