using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{


    public TMP_Text timerText;
    public float countdownDuration = 60f; // Change this to the duration of your countdown in seconds

    public GameObject Ending;

    private float timer;

    void Start()
    {
        timer = countdownDuration;
        Ending.SetActive(false);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        // Update the timer text to display the remaining time
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timer <= 0)
        {
            // Timer has reached zero, you can add your end of countdown logic here
            //Debug.Log("Countdown Finished");
            Ending.SetActive(true);
            timer = 0; // Ensure timer doesn't go negative
        }
    }
}
