using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTransport : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _mainmenu;
    [SerializeField] GameObject _transport;
    [SerializeField] GameObject _transportmenu;
    public void BuyVehicle()
    {
        _mainmenu.SetActive(false);
        _transport.SetActive(false);
        _transportmenu.SetActive(true);
    }
}
