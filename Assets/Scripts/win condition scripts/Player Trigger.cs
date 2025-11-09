
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public int score;
    public GameObject coin;

    void start()
    {
        coin.SetActive(true);
    }

 

    private void OnCollisionEnter(Collision collision)
    {
        score += 1;
        Debug.Log(score);
        coin.SetActive(false);
    }
}
