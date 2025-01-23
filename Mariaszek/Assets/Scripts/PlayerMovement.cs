using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance { get; private set; }
    public bool isMovementFrozen = false;

    public float moveSpeed;

    public float groundDrag;
    public LayerMask Ground;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    //public Animator playerAnimation;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        
        else
        {
            Instance = this;
        }
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        MyInput();
        SpeedControl();

        rb.drag = groundDrag;

        // if (Input.GetKey(KeyCode.W))
        // {
        //     playerAnimation.Play("Back walk");
        // }

        // else if (Input.GetKey(KeyCode.A))
        // {
        //      playerAnimation.Play("Left walk");
        // }

        // else if (Input.GetKey(KeyCode.S))
        // {
        //     playerAnimation.Play("Front walk");
        // }

        // else if (Input.GetKey(KeyCode.D))
        // {
        //      playerAnimation.Play("Right walk");
        // }

        // else
        // {
        //      playerAnimation.Play("Idle");

        // }
    }

    void FixedUpdate()
    {
        if (isMovementFrozen)
        return;

        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    public void FreezeMovement()
    {
        isMovementFrozen = true;
    }

    public void DefrostMovement()
    {
        isMovementFrozen = false;
    }
}