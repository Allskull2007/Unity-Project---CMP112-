using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public GameObject Door;
    void Start()
    {
        Door.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
            Door.SetActive(true);
    }

}
