using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameras : MonoBehaviour
{
    public Camera[] cameras;
    int camAtual;

    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            camAtual++;
            if (camAtual == cameras.Length)
            {
                camAtual = 0;
            }
        }
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i != camAtual)
            {
                cameras[i].depth = 0;
            } 
            cameras[camAtual].depth = 1;
        }
    }

   

}
