using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;


public class NewDelivery : MonoBehaviour
{
    [SerializeField] GameObject _deliveryUI;
    [SerializeField] GameObject _taskBegins;
    [SerializeField] GameObject _minimap;
    [SerializeField] GameObject _pause;
    [SerializeField] GameObject _AudioTest;
    [SerializeField] GameObject _HerdLevelChooose;


    public void Delivery()
    {
        
        _AudioTest.SetActive(false);
        AudioListener.pause = false;

        Time.timeScale = 1.0f;
        _deliveryUI.SetActive(false);
        _taskBegins.SetActive(true);
        _minimap.SetActive(true);
        StartTimer();
        _pause.SetActive(true);
        _HerdLevelChooose.SetActive(false);







    }
    public TextMeshProUGUI timer;
    public float lifeTime = 30
        ;
    [SerializeField] GameObject _Timer;


    static public bool TimeSkip;

    public bool start = false;
    static public bool stop = false;
    public void StartTimer()
    {
        start = true;
    }
    static public void StopTimer()
    {
        stop = true;
    }

    void Update()
    {

        if (start == true)
        {
            TimeSkip = true;
            _Timer.SetActive(true);
            timer.text = Math.Round(lifeTime) + " сек";
            lifeTime -= 1 * Time.deltaTime;
            if (lifeTime < 0)
            {
                TimeSkip = false;
            }

        }
        if (stop == true)
        {
            _Timer.SetActive(false);
            lifeTime = 30;
            stop = false;
            start = false;
        }

    }
}
