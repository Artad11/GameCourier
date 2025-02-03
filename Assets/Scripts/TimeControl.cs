using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    [SerializeField] GameObject _newDelivery;
    float  _time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _newDelivery.SetActive(false);
        Time.timeScale = 50.0f;
        Invoke("MissionStart", 50f);
        Invoke("NormalTime", 50f);




    }

    void MissionStart()
    {
        _newDelivery.SetActive(true);
    }
    // Update is called once per frame
    void NormalTime()
    {
        Time.timeScale = 1.0f;
    }
}
