using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardLevelChoose : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _startMenu;
    [SerializeField] GameObject _chooseHardLevel;

    public void ChooseLevel()
    {
        _startMenu.SetActive(false);
        _chooseHardLevel.SetActive(true);
    }
    public void BackToStartMenu()
    {
        _startMenu.SetActive(true);
        _chooseHardLevel.SetActive(false);
    }

}
