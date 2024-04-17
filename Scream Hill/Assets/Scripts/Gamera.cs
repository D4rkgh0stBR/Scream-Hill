using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamera : MonoBehaviour
{
    
    public Transform CharacterBody; // Personagem
    public Transform CharacterHead; // Cabeça

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

void Update()
{
        

        float verticalDelta = Input.GetAxisRaw("Mouse Y");
        float horizontalDelta = Input.GetAxisRaw("Mouse X");

        rotationX += horizontalDelta;
        rotationY += verticalDelta;
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        CharacterBody.localEulerAngles = new Vector3(0, rotationX, 0);
        transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
    }
    
        
    

}
