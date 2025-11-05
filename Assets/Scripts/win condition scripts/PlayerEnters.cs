using UnityEngine;

public class PlayerEnters : MonoBehaviour
{
    public int score = 0;
    private void OnCollisionEnter(Collision collision){
        score += 1;
        Debug.Log("score: " + score);
        Pose.position = (0, 0, -216);
        if (score >=5) {
            Destroy(this);
        }
    }
}