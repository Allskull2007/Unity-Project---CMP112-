
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public int score;
    public GameObject coin;


 

    private void OnCollisionEnter(Collision collision)
    {
        score += 1;
        Debug.Log(score);
    }
}
