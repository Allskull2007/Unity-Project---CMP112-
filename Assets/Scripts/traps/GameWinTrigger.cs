using UnityEngine;

public class GameWinTrigger : MonoBehaviour
{
    public bool win = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        win = true;
    }
    private void OnTriggerExit(Collider other)
    {
        win = false;
    }
}
