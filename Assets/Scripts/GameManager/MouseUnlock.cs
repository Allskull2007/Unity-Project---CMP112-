using UnityEngine;

public class MouseUnlock : MonoBehaviour
{

    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
