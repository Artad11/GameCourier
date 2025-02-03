using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class UnableCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private SC_CameraCollision SC_CameraCollision;
    private CameraLook CameraLook;
    public static UnableCamera Instanse;

    public void CameraPlay()
    {
        if (Application.isMobilePlatform)
        {
            CameraLook = GetComponent<CameraLook>();

            CameraLook.enabled = true;
           



        }
        else
        {
            SC_CameraCollision = GetComponent<SC_CameraCollision>();

            SC_CameraCollision.enabled = true;

            Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;

        }

    }
    public void CameraStop()
    {

        if (Application.isMobilePlatform)
        {
           

        }
        else
        {

            SC_CameraCollision = GetComponent<SC_CameraCollision>();
            
            SC_CameraCollision.enabled = false;

        }
    }
}
