using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// I'm not sure notations are needed for this code but I will try somehow
    /// </summary>

    public float MovementSpeed;  // allows us to change the speed of the player
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");  
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical + transform.right * moveHorizontal; // creates a new Vector based of the player's input
        movement.Normalize();
        rb.MovePosition(rb.position + movement * MovementSpeed); // Looks at current position, looks at what the player's inputs are and times it by our set speed
    }

}
