using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float velocity = 10.0f, rotation = 90.0f;

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
            
    }
}
