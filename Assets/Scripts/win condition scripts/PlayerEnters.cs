using UnityEngine;

public class PlayerEnters : MonoBehaviour
{
    public int score = 0;
    private void OnCollisionEnter(Collision collision){
        score += 1;
        Debug.Log("score: " + score);
        transform.position = new Vector3(0, 0, -211);
        if (score >=5) {
            Destroy(gameObject);
        }
    }
}