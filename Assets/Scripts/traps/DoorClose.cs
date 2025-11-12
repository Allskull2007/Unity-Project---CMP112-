using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public GameObject Door;
    int counter;
    public Timer timer;
    void Start()
    {
        Door.SetActive(false);  //Start the game with door turned off
    }

    private void OnTriggerEnter(Collider other)
    {
        if (counter < 1)   //The door does not re-Activate when eneetr the trigger again
        {
            Door.SetActive(true);
            counter++;
        }
    
        if(timer != null)
        {
            timer.TimerStart = true;   //Starts the timer once the door closes
        }
    
    }
}
