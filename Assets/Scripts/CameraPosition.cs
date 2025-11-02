using UnityEngine;

public class CameraPosition : MonoBehaviour
{

    public Transform Cameraposition;
    
    void Update()
    {
        transform.position = Cameraposition.position;
    }
}
