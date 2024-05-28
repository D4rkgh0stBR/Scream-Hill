using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heli : MonoBehaviour
{
    public float liftForce = 5f;
    public float moveSpeed = 5f;
    public float turnSpeed = 2f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.useGravity = false; // Desativar gravidade para um controle mais realista
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        // Controle de subida e descida
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * liftForce, ForceMode.Acceleration);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.AddForce(Vector3.down * liftForce, ForceMode.Acceleration);
        }

        // Controle de movimento para frente e para os lados
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * moveVertical + transform.right * moveHorizontal;
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);

        // Controle de rotação
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -turnSpeed);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, turnSpeed);
        }
    }




























    /*public GameObject helicoptero;
    public float motor;
    Rigidbody rB;
    
    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            força();
        }
    }

    void força()
    {
        rB.AddForce(Vector3.up * motor, ForceMode.Impulse);
    }*/
}
