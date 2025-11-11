using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerTrigger : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI Score;
    public GameObject Door;
    public GameWinTrigger GameWinTrigger;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))  //Checks if coin is tagged coin
        {
            coin += 1;
            Destroy(other.gameObject); //Destroyes the collected coin
            if (coin >= 5)
            {
                Door.SetActive(false); //So the door does not open early
            }
        }
    }

    void Update()
    {
        Score.text = System.Convert.ToString("Score: " + coin);  //UI to display the score
        if (GameWinTrigger.win == true && coin >= 5) { //If all conditions are met the win scene loads
            SceneManager.LoadScene(3);
        }
    }

}