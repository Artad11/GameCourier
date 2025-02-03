using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppPaused : MonoBehaviour
{
    bool isPaused = false;

    void OnGUI()
    {
        if (isPaused)
            GUI.Label(new Rect(100, 100, 50, 30), "Game paused");
    }

    void OnApplicationFocus(bool hasFocus)
    {
        isPaused = !hasFocus;
        /*if (isPaused == true){
            Progress.Instanse.GraStopPublic();
        }
        if (isPaused == false)
        {
            Progress.Instanse.GraStartPublic();
        }*/

    }

    void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;

        
    }

}
