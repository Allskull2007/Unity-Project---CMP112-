using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
public class PlayerTrigger : MonoBehaviour
{
    public PlayerEnters PlayerEnters;
    public TextMeshProUGUI Score;
   
    private void Awake()
    {
        transform.position = PlayerEnters.startingPos[0];
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerEnters.score = CaculateScore(PlayerEnters.score);
        Debug.Log(PlayerEnters.score);
        Destroy(gameObject);
    }
    int CaculateScore(int score)
    {
        score += 1;
        return score;

    }

}
