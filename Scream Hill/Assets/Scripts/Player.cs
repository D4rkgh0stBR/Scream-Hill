using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    

    CharacterController controller;
    Vector3 forward, strafe, vertical;
    float forwardSpeed = 10f, strafeSpeed = 5f, gravity, jumpSpeed, maxJumpHeight = 2f, timeToMaxHeight = 0.5f;

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

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            vertical = jumpSpeed * Vector3.up;
        }

        Vector3 finalVelocity = forward + strafe + vertical;
        controller.Move(finalVelocity * Time.deltaTime);

        
    }

    void OnTriggerEnter(Collider tri)
    {
        if (tri.gameObject.CompareTag("Key"))
        {
            CMD.chave++;
            
        }

        if (tri.gameObject.CompareTag("Municao"))
        {
            CMD.municao += 100;
        }

        if (tri.gameObject.CompareTag("Coisa"))
        {
            CMD.vida -= 10;
            Debug.Log("colidiu");
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        
    }

}
