using UnityEngine;

public class WinConspawn4 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(188, 5, -24);
                break;
            case 2:
                transform.position = new Vector3(-161, 5, 7);
                break;
            case 3:
                transform.position = new Vector3(-187, 5 , -47);
                break;
        }
    }
}
