using UnityEngine;

public class THECamera : MonoBehaviour
{
    public float sensX;
    public float sensY;
    float xRotation;
    float yRotation;
    public Transform Direction;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -85f, 85f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        Direction.rotation = Quaternion.Euler(0f, yRotation, 0f);

    }


}
