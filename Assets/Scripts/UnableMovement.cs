using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnableMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private SC_TPSController _TPSController;
    private PlayerControllerOnMobile _Mobile;
    private TouchController _TouchController;
    [SerializeField] GameObject _joystick;
    public static UnableMovement Instanse;
    private AudioListener _AudioListener;
    public AudioSource _AudioSource;
    
    public void Play()
    {

        AudioPlay();
        if (Application.isMobilePlatform)
        {
            _Mobile = GetComponent<PlayerControllerOnMobile>();
            _TouchController = GetComponent<TouchController>();
            _Mobile.enabled = true;
            _TouchController.enabled = true;
            _joystick.SetActive(true);



        }
        else
        {
            _TPSController = GetComponent<SC_TPSController>();
            _TPSController.enabled = true;
        }

    }
    public void MovementStop()
    {
        AudioStop();
        if (Application.isMobilePlatform)
        {
          

        }
        else
        {
            _TPSController = GetComponent<SC_TPSController>();
            _TPSController.enabled = false;
        }

    }
    public void AudioPlay()
    {
        _AudioListener = GetComponent<AudioListener>();
        _AudioListener.enabled = true;
    }
    public void AudioStop()
    {
        _AudioListener = GetComponent<AudioListener>();
        _AudioListener.enabled = false;
    }
    public void StopAudioSource()
    {
        _AudioSource = GetComponent<AudioSource>();
        _AudioSource.enabled = false;
    }
}
