using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
<<<<<<< HEAD

public class PlayerTrigger : MonoBehaviour
{

    public int coin = 0;
    public TextMeshProUGUI Score;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            coin++;
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        Score.text = System.Convert.ToString("Score: " + coin);
    }

=======
using UnityEngine.SceneManagement;


public class PlayerTrigger : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI Score;
    public GameObject Door;
    public bool win = false;
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
        if (other.CompareTag("GameWinTrigger")) {
            win = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("GameWinTrigger")) {
            win = false;
        }
    }

    void Update()
    {
        Score.text = System.Convert.ToString("Score: " + coin);  //UI to display the score
        if (win == true && coin >=5) {
            Debug.Log("hello");
            SceneManager.LoadScene(3);
        }
    } 
>>>>>>> Before-the-errors
}
