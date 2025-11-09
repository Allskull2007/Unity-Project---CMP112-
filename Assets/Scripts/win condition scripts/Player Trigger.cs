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
    public int score;

    private void OnCollisionEnter(Collision collision)
    {
        score += 1;
        Debug.Log(score);
        Destroy(gameObject);
    }
}
