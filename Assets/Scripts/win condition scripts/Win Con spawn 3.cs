using UnityEngine;

public class WinConspawn3 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 10);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(86, 5, 380);
                break;
            case 2:
                transform.position = new Vector3(-110, 5, 380);
                break;
            case 3:
                transform.position = new Vector3(50, 5, 197);
                break;
        }
    }
}

