using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMovement : MonoBehaviour
{
    private SC_TPSController _TPSController;
    private UnablePlayerController _UnablePlayerController;
  
    public void PauseGame() 
    {
        if (Application.isMobilePlatform)
        {

        }
        else
        {

            _TPSController = GetComponent<SC_TPSController>();
            _UnablePlayerController = GetComponent<UnablePlayerController>();
            _TPSController.enabled = false;
            _UnablePlayerController.enabled = true;
        }
    }
    public void ContinueGame()
    {
        if (Application.isMobilePlatform)
        {

        }
        else
        {

            _TPSController = GetComponent<SC_TPSController>();
            _UnablePlayerController = GetComponent<UnablePlayerController>();
            _TPSController.enabled = true;
            _UnablePlayerController.enabled = false;
        }
    }
}
