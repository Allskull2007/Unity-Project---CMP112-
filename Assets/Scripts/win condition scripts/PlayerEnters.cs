using UnityEngine;

public class PlayerEnters : MonoBehaviour
{
    public int score = 0;

    private void OnCollisionEnter(Collision collision) {
        score = CaculateScore(score);
        //doesn't work currently as I'm not sure how to get a vector out of a fuction but I'm going to ask on Friday
        //transform.position = new Vector3 (changeCoinLocation(score));

        int CaculateScore(int score)
        {
            score += score;
            return score;
        }

        void changeCoinLocation(int score)
        {
            Vector3 position = new Vector3(0, 0, 0);
            //couldn't really think of a way to do this with loops or more efficeintly but if you figure something out feel free to change it
            if (score == 1)
            {
                //the positions in the vectors currently are place holder values
                position = new Vector3(0, 0, -211);
            }
            if (score == 2)
            {
                position = new Vector3(0, 0, -211);
            }
            if (score == 3)
            {
                position = new Vector3(0, 0, -211);
            }
            if (score == 4)
            {
                position = new Vector3(0, 0, -211);
            }
            if (score >= 5)
            {
                Destroy(gameObject);
                //game sequence ends, not sure how to code that so just leaving it for now
            }
            //return position;
        }
    }
}