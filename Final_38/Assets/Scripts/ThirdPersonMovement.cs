using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float bounceVel = 100f;

    public Transform groundCheck;
    public float groundDistance = 0.35f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Check if player is on ground

        if(isGrounded && velocity.y < 0) //Reset the vertical velocity if character is on the ground
        {
            velocity.y = -2f;
        }

        //Get controls and make a direction vector from them
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        //Get camera angle and smoothly translate character to face camera direction
        float lookAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, cam.eulerAngles.y, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, lookAngle, 0f);

        //Move the character if directional input is detected
        if (direction.magnitude >= 0.1f)
        {
            Vector3 moveDir = Vector3.ClampMagnitude(transform.right * horizontal + transform.forward * vertical, 1.0f);
            controller.Move(moveDir * speed * Time.deltaTime);
        }

        if (Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bouncy")
        {
            velocity.y = bounceVel;
        }
    }
}
