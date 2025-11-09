using UnityEngine;

public class WinConspawn1 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(238, 5, 23);
                break;
            case 2:
                transform.position = new Vector3(188, 5, 318);
                break;
            case 3:
                transform.position = new Vector3(50, 5, 197);
                break;
        }
    }
}
