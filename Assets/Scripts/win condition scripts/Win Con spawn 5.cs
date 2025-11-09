using UnityEngine;

public class WinConspawn5 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(145, 5, 144);
                break;
            case 2:
                transform.position = new Vector3(230, 5, 180);
                break;
            case 3:
                transform.position = new Vector3(-109, 5, 20);
                break;
        }
    }
}
