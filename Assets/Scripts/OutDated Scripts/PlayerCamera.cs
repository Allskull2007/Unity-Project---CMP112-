using UnityEngine;

/// <summary>
/// This camera does not allow any movement ( could cause issue when turning around / wanting to look a direction that is not forward )
/// </summary>


public class PlayerCamera : MonoBehaviour
{
    public Transform player;   // checks where the player is
    private Vector3 _offset;   // distance between player and camera

    private void Awake()
    {
        _offset = transform.position - player.position; // calculate the offset when project is ran
    }

    private void LateUpdate()
    {
        transform.position = player.position + _offset; // move the camera with the player at the ame distance as when the project was started.
       
    }

}
