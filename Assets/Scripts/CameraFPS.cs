using UnityEngine;

public class CameraFPS : MonoBehaviour
{

    public Transform Player;
    public float CameraSens;
    private float xRotation =0f;
    private float yRotation = 0f;
    Vector3 Rotation;

    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        float mouseX = Input.GetAxis("Mouse X") * CameraSens;
        float mouseY = Input.GetAxis("Mouse Y") * CameraSens;

        yRotation += mouseX;
        xRotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Player.rotation = Quaternion.Euler(0f, yRotation, 0f);
     

    }

    private void LateUpdate()
    {
        transform.position = Player.position;

    }


}
