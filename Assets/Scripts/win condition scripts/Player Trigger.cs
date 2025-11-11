using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerTrigger : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI Score;
    public GameObject Door;
    public GameWinTrigger GameWinTrigger;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coin += 1;
            Destroy(other.gameObject);
            if (coin >= 5)
            {
                Door.SetActive(false);
            }
        }
    }

    void Update()
    {
        Score.text = System.Convert.ToString("Score: " + coin);
        if (GameWinTrigger.win == true && coin >= 5) {
            //Debug.Log("Hello");
            //replace this with code to switch to the win screen
        }
    }

}