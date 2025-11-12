using UnityEngine;

public class PlayerTrigger1 : MonoBehaviour
{
    private void Awake()
    {
        int randomInt = Random.Range(1, 3);
        switch (randomInt)
        {
            case 1:
                transform.position = new Vector3(-194, 5, 54);
                break;
            case 2:
                transform.position = new Vector3(-141, 5, -84);
                break;
            case 3:
                transform.position = new Vector3(62, 5, -161);
                break;
        }
    }
}
