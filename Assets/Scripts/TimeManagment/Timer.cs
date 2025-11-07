using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    int currentTimeInt;
    public float StartTime;
    public TextMeshProUGUI Amount;

    void Start()
    {
        currentTime = StartTime;
    }
    void Update()
    {
        currentTime = currentTime - Time.deltaTime;
        currentTimeInt = System.Convert.ToInt32(currentTime);
        Amount.text = System.Convert.ToString("Time: " + currentTimeInt);


    }
}