using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class PlayerCameraRotation : MonoBehaviour
{
    /// <summary>
    /// Another camera code that should HOPEFULLY allow the player to move the camera around the player ( it might rotate the player aswell but this depends on what feels/looks the best
    /// </summary>

    public Transform Player;
    public float CameraSens;
    private Vector3 _offset;
    Vector3 Rotation;

    void Awake()
    {
        _offset = transform.position - Player.position;
    }


    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void LateUpdate()
    {
        transform.position = Player.position + _offset;

        Rotation.x += Input.GetAxis("Mouse X") * CameraSens;
        Rotation.y -= Input.GetAxis("Mouse Y") * CameraSens;

        Rotation.y = Mathf.Clamp(Rotation.y, -80f, 80f);
        transform.rotation = Quaternion.Euler(Rotation.y, Rotation.x, 0f);
        Quaternion rotation = Quaternion.Euler(Rotation.y, Rotation.x, 0f);
        transform.position = Player.position + rotation * _offset;
        transform.LookAt(Player);
    }
}
