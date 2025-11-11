using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public PlayerTrigger PlayerTrigger;
    public GameObject Door;
    int counter;
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
    }
}
