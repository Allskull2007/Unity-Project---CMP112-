using UnityEngine;

public class WinConspawn5 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(159, 5, 77);
                break;
            case 2:
                transform.position = new Vector3(212, 5, -11);
                break;
            case 3:
                transform.position = new Vector3(-124, 5, -144);
                break;
        }
    }
}
