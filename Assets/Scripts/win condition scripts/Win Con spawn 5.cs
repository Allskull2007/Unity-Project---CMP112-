using UnityEngine;

public class WinConspawn5 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(154, 5, 90);
                break;
            case 2:
                transform.position = new Vector3(180, 5, -11);
                break;
            case 3:
                transform.position = new Vector3(-159, 5, -171);
                break;
        }
    }
}
