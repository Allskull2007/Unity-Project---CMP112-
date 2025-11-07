using UnityEngine;

public class HowTo : MonoBehaviour
{
    public GameObject HowToPlay;
    void Start()
    {
        HowToPlay.SetActive(false);
    }

    public void OpenHowTo()
    {
        HowToPlay.SetActive(true);
    }
}
