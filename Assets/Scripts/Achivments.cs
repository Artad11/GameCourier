using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achivments : MonoBehaviour
{
    [SerializeField] GameObject _menu;
    [SerializeField] GameObject _achivmentMenu;

    public void AchivmentsEnabled()
    {
        _menu.SetActive(false);
        _achivmentMenu.SetActive(true);
        
    }
    public void AchivmentsDisabled()
    {
        _menu.SetActive(true);
        _achivmentMenu.SetActive(false);
    }
}
