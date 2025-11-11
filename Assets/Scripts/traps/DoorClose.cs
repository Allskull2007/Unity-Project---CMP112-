using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public GameObject Door;
    int counter;
    public Timer timer;
    void Start()
    {
        Door.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (counter < 1)
        {
            Door.SetActive(true);
            counter++;
        }
    
        if(timer != null)
        {
            timer.TimerStart = true;
        }
    
    }
}
