using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
public class PlayerTrigger : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public ScoreCounter ScoreCounter;


    private void Awake()
    {
        int randomInt = Random.Range(1, 10);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(50, -7, -200);
                break;
            case 2:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 3:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 4:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 5:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 6:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 7:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 8:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 9:
                transform.position = new Vector3(50, 2, -200);
                break;
            case 10:
                transform.position = new Vector3(50, 2, -200);
                break;
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        ScoreCounter.score += 1;
        Debug.Log(ScoreCounter.score);
        Destroy(gameObject);
    }
}
