using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutraCamera : MonoBehaviour
{
    public Transform _transform, cameraTransform;

    Vector2 rotacaoMouse;
    public int sensibilidade;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 controleMouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        rotacaoMouse = new Vector2 (rotacaoMouse.x + controleMouse.x * rotacaoMouse.y + controleMouse.y *
                                    sensibilidade * Time.deltaTime, sensibilidade * Time.deltaTime);

        _transform.eulerAngles = new Vector3(_transform.eulerAngles.x, rotacaoMouse.x, _transform.eulerAngles.z);

        rotacaoMouse.y = Mathf.Clamp(rotacaoMouse.y, -80, 80);

        cameraTransform.localEulerAngles = new Vector3(-rotacaoMouse.y, cameraTransform.localEulerAngles.y, cameraTransform.localEulerAngles.z);
    }
}
