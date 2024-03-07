using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    //public BeatScroller theBS;
    public TopToDownScroller theTopToDown;
    public RightToCenterScroller theRightToCenter;
    public LeftToCenterScroller theLeftToCenter;
    public Left45Scroller theLeft45;
    public Right45Scroller theRight45;

    public ChildrenController theCC;

    public static GameManager instance;

    

    public int currentScore;
    public int scorePerNote = 100;

    // public int currentMultiplier;
    //public int multiplierTracker;
    //public int[] multiplierThresholds;

    public TMP_Text scoreText;
    //public TMP_Text multiplier;


    public GameObject WinCanvas;
    public GameObject LoseCanvas;



   


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        //multiplier.text = "Multipier:x1";
        scoreText.text = "Score: 0";
        //currentMultiplier = 1;

        WinCanvas.SetActive(false);
        LoseCanvas.SetActive(false);





    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;

                //theBS.hasStarted = true;
                theTopToDown.hasStarted = true;
                theRightToCenter.hasStarted = true;
                theLeft45.hasStarted = true;
                theRight45.hasStarted = true;
                theLeftToCenter.hasStarted = true;

                //theCC.hasStarted = true;

                theMusic.Play();
            }
        }
        Ending();
    }

    public void NoteHit()
    {
        //Debug.Log("hit on time");
        



        currentScore += scorePerNote;
        scoreText.text = "Score:" + currentScore.ToString();
    }

    public void NoteMissed()
    {
        //Debug.Log("You miss");
        

    }


    public void Ending()
    {
        if (currentScore >= 500)
        {
            //Debug.Log("You Win");
            WinCanvas.SetActive(true);
            LoseCanvas.SetActive(false);
        }
        if (currentScore < 100)
        {
            //Debug.Log("You Lose");
            LoseCanvas.SetActive(true);
            WinCanvas.SetActive(false);
        }
    }
}
