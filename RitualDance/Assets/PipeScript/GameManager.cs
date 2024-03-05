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


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        //multiplier.text = "Multipier:x1";
        scoreText.text = "Score: 0";
        //currentMultiplier = 1;
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

                theCC.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("hit on time");



        currentScore += scorePerNote;
        scoreText.text = "Score:" + currentScore.ToString();
    }

    public void NoteMissed()
    {
        Debug.Log("You miss");


    }
}
