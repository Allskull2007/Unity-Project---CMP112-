using UnityEngine;

public class THEMovement : MonoBehaviour
{

    public float MovementSpeed;
    public Transform Direction;
    public float GroundDrag;

    float horizontalInput;
    float verticalInput;

    Vector3 MoveDirection;
    Rigidbody Rigidbody;

    public float PlayerHeight;
    public LayerMask Ground;
    bool grounded;

    public float JumpPower;
    public float JumpCooldown;
    bool Jump;
    public KeyCode jumpKey = KeyCode.Space;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.freezeRotation = true;
        Jump = true;
    }

    void Update()
    {
        MyMovement();
        SpeedController();

        Debug.DrawRay(transform.position, Vector3.down * (PlayerHeight * 0.10f + 0.5f), grounded ? Color.green : Color.red);


        grounded = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.90f + 0.2f, Ground);
        if (grounded)
        {
            Rigidbody.linearDamping = GroundDrag;
        }
        else
        {
            Rigidbody.linearDamping = 0;
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
            Invoke(nameof(canJump), JumpCooldown);

        }
    }

    private void CalcMovement()
    {
        MoveDirection = Direction.forward * verticalInput + Direction.right * horizontalInput;
        Rigidbody.AddForce(MoveDirection.normalized * MovementSpeed * 10f, ForceMode.Force);
    }

    private void SpeedController()
    {
        Vector3 FlatVel =  new Vector3(Rigidbody.linearVelocity.x, 0f, Rigidbody.linearVelocity.z);

        if (FlatVel.magnitude > MovementSpeed)
        {
            Vector3 LimitSpeed = FlatVel.normalized * MovementSpeed;
            Rigidbody.linearVelocity = new Vector3(LimitSpeed.x, Rigidbody.linearVelocity.y , LimitSpeed.z);
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
