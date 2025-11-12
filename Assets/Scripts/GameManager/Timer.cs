using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    float currentTime = 300f;
    int currentTimeInt;
    public float StartTime;
    public TextMeshProUGUI Amount;
    public bool TimerStart = false;

    void Start()
    {
        currentTime = StartTime;
        Amount.text = "Time: " + Mathf.CeilToInt(currentTime); //shows the Timer before its triggerd by the door closing
    }
    void Update()
    {
        if (TimerStart)   //Only runs while TimerStart is true to make sure it only starts once the door is closed
        {
            currentTime = currentTime - Time.deltaTime; //Decrease Time
            currentTimeInt = System.Convert.ToInt32(currentTime);  //Converts time to an Int to display

            Amount.text = System.Convert.ToString("Time: " + currentTimeInt); //updates the UI

            if (currentTimeInt <= 0f)
            {
                TimerStart = false;  //stops the Timer
                SceneManager.LoadScene(2);  //Sends to fail screen
            }
        }
   
    }
}