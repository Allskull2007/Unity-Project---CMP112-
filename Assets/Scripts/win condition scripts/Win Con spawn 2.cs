using UnityEngine;

public class PlayerTrigger1 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(-144, 5, 245);
                break;
            case 2:
                transform.position = new Vector3(-92, 5, 107);
                break;
            case 3:
                transform.position = new Vector3(112, 5, 30);
                break;
        }
    }
}
