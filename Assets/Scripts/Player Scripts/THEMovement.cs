using UnityEngine;

public class THEMovement : MonoBehaviour
{
    [Header("Movement")]
    public float MovementSpeed;
    public Transform Direction;
    public float GroundDrag;

    float horizontalInput;
    float verticalInput;

    Vector3 MoveDirection;
    Rigidbody Rigidbody;

    [Header("Ground Check")]
    public float PlayerHeight;
    public LayerMask Ground;
    bool grounded;

    [Header("Jumping")]
    public float JumpPower;
    public float JumpCooldown;
    bool Jump;
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Sprint")]
    public float SprintMultiplier;
    public KeyCode Sprinting = KeyCode.LeftShift;
    private bool IsSprinting;



    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.freezeRotation = true;

        Jump = true;
    }

    void Update()
    {
        MyMovement();
        
        grounded = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.90f + 0.2f, Ground);  //adds drag to the player and so when jumping dont go super far.
        if (grounded)
        {
            Rigidbody.linearDamping = GroundDrag;
        }
        else
        {
            Rigidbody.linearDamping = 1;
        }

    }

    void FixedUpdate()
    {
        CalcMovement();
    }

    private void MyMovement()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(jumpKey) && Jump && grounded)
        {
            Jump = false;
            Jumping();
            Invoke(nameof(canJump), JumpCooldown); //allows the player to jump again after a very small delay

        }

        IsSprinting = Input.GetKey(Sprinting);

    }

    private void CalcMovement()
    {
        float currentSpeed = MovementSpeed; 

        MoveDirection = Direction.forward * verticalInput + Direction.right * horizontalInput;

        if (Input.GetKey(Sprinting))
        {
            currentSpeed *= SprintMultiplier;
        }
        if ( grounded )
        {
            Rigidbody.AddForce(MoveDirection.normalized * currentSpeed * 10f, ForceMode.Force);
        }
        else
        {
            Rigidbody.AddForce(MoveDirection.normalized * currentSpeed * 3f, ForceMode.Force);
        }
    }


    private void Jumping()
    {
        Rigidbody.linearVelocity = new Vector3(Rigidbody.linearVelocity.x, 0f, Rigidbody.linearVelocity.z);
        Rigidbody.AddForce(transform.up * JumpPower, ForceMode.Impulse);
    }
    private void canJump()
    {
        Jump = true;
    }

}
