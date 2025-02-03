using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportMenu : MonoBehaviour
{
    
    [SerializeField] GameObject _buttons;
    [SerializeField] GameObject _transport;
    [SerializeField] GameObject _choosevehcle;
    
    public void Back()
    {
        _buttons.SetActive(true);
        _transport.SetActive(true);
        _choosevehcle.SetActive(false);
    }
}
