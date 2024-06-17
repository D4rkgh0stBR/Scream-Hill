using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamera : MonoBehaviour
{
    /*public Transform CharacterBody;
    public Transform CharacterHead;
    public Camera Camera;
    float rotationX = 0;
    float rotationY = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void LateUpdate()
    {
        transform.position = CharacterHead.position;
    }
    private void Update()
    {
        float verticalDelta = Input.GetAxisRaw("Mouse Y");
        float horizontalDelta = Input.GetAxisRaw("Mouse X");

        rotationX += horizontalDelta;
        rotationY += verticalDelta;
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        CharacterBody.localEulerAngles = new Vector3(0, rotationX, 0);
        transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
    }*/





























    public float mouseSensitivity = 100f;
    public Transform playerBody;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
