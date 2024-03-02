using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;
    public TMP_Text timer;

    private void Start()
    {
        timerOn = true;
    }

    private void Update()
    {
        if(timerOn)
        {
            
                timeLeft += Time.deltaTime;
                updateTimer(timeLeft);
            


        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timer.text = string.Format("{0:00} : {1:00}",minutes,seconds);
    }

    public void timerPause()
    {
        timerOn= false;
    }
    public void timerResume()
    {
        timerOn = true;
    }
}
