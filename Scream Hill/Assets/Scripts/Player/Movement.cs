using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    CharacterController controller;
    Vector3 forward;
    Vector3 strafe;
    Vector3 vertical;

    public float forwardSpeed = 5f, strafeSpeed = 5f;

    public float jumpSpeed, gravity, maxJumpHeight = 2f, timeToMaxHeight = 0.5f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        gravity = (-2 * maxJumpHeight) / (Mathf.Pow(timeToMaxHeight, 2));
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float strafeInput = Input.GetAxis("Horizontal");

        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        vertical += gravity * Time.deltaTime * Vector3.up;

        if (controller.isGrounded)
        {
            vertical = Vector3.down;
        }

        if(Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            vertical = jumpSpeed * Vector3.up;
        }
        Vector3 finalVelocity = forward + strafe + vertical;
        controller.Move (finalVelocity * Time.deltaTime);
    }























       /* public float velocity = 10.0f, rotation = 90.0f;
        float forwardSpeed = 5f, strafeSpeed = 5f, jumpSpeed, gravity, maxJumpHeight = 2f, timeToMaxHeight = 0.5f;

        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            Vector3 direcao = new Vector3(x, 0, y) * velocity;

            transform.Translate(direcao * Time.deltaTime);

            transform.Rotate(new Vector3 (mouseY * rotation * Time.deltaTime, mouseX * rotation * Time.deltaTime, 0));

        }*/
}
