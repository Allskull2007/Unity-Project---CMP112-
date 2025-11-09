using UnityEngine;

public class WinConspawn4 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(238, 5, 167);
                break;
            case 2:
                transform.position = new Vector3(-112, 5, 198);
                break;
            case 3:
                transform.position = new Vector3(-137, 5 , 144);
                break;
        }
    }
}
