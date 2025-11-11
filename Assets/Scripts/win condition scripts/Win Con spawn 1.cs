using UnityEngine;

public class WinConspawn1 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(188, 5, -160);
                break;
            case 2:
                transform.position = new Vector3(138, 5, 108);
                break;
            case 3:
                transform.position = new Vector3(80, 5, -48);
                break;
        }
    }
}
