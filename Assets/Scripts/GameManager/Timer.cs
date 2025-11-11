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
        Amount.text = "Time: " + Mathf.CeilToInt(currentTime);
    }
    void Update()
    {
        if (TimerStart)
        {
            currentTime = currentTime - Time.deltaTime;
            currentTimeInt = System.Convert.ToInt32(currentTime);

            Amount.text = System.Convert.ToString("Time: " + currentTimeInt);

            if (currentTimeInt <= 0f)
            {
                TimerStart = false;
                SceneManager.LoadScene(2);
            }
        }
    

 



    }
}