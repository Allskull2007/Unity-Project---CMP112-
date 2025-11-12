using UnityEngine;

public class WinConspawn3 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 10);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(36, 5, 189);
                break;
            case 2:
                transform.position = new Vector3(-160, 5, 189);
                break;
            case 3:
                transform.position = new Vector3(0, 5, 6);
                break;
        }
    }
}

