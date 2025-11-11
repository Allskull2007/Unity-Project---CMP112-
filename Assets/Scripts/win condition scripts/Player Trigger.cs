using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerTrigger : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI Score;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coin += 1;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        Score.text = System.Convert.ToString("Score: " + coin);

    }

}