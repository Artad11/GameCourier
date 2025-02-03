using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    
    [SerializeField] GameObject _pause;
    [SerializeField] GameObject _pauseMenu;
    [SerializeField] GameObject _audioTest;
    public void PauseGame() 
    {


        Time.timeScale = 0.0f;
        _pause.SetActive(false);
        _pauseMenu.SetActive(true);
        _audioTest.SetActive(true);
        AudioListener.pause = true;

    }
    public void ContinueGame()
    {
        
        _audioTest.SetActive(false);
        _pause.SetActive(true);
        _pauseMenu.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1.0f;
        if (Application.isMobilePlatform)
        {

        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
        }


    }
}
