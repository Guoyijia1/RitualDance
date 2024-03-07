using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSound : MonoBehaviour
{
    public AudioSource keyA;
    public AudioSource keyS;
    public AudioSource keyD;
    public AudioSource keyF;
    public AudioSource keyG;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            keyA.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            keyS.Play();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            keyD.Play();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            keyF.Play();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            keyG.Play();
        }
    }
}
