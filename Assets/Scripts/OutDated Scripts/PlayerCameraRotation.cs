using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class PlayerCameraRotation : MonoBehaviour
{
    /// <summary>
    /// First Person camera that allows the uster to look around
    /// </summary>

    public Transform Player;
    public float CameraSens;
    Vector3 Rotation;



    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void LateUpdate()
    {
        transform.position = Player.position;

        Rotation.x += Input.GetAxis("Mouse X") * CameraSens;
        Rotation.y -= Input.GetAxis("Mouse Y") * CameraSens;

        Rotation.y = Mathf.Clamp(Rotation.y, -80f, 80f);
        transform.rotation = Quaternion.Euler(Rotation.y, Rotation.x, 0f);
        Quaternion rotation = Quaternion.Euler(Rotation.y, Rotation.x, 0f);
      
    }
}
