using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeBugLog : MonoBehaviour
{
    public GameObject gDebug;
    public bool bPauseDebug;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            dbugOn();
        }
    }

    void dbugOn()
    {
        Time.timeScale = 0;
        gDebug.SetActive(true);
    }

    void dbugOff()
    {
        Time.timeScale = 1;
        gDebug.SetActive(false);
    }
}
