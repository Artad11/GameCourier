using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{
    private GameObject[] _characters;
    public GameObject _leftButton;
    public GameObject _rightButton;
    public GameObject _BuyBike;
    public GameObject _BuyScooter;
    public GameObject _SelectVehicle;
    static public float Bike = 0;
    static public float Scooter = 0;
    public int index;
    static public PlayerSelect Instance;

    
    private void Start()
    {
        
        index = PlayerPrefs.GetInt("SelectPlayer");
        _characters = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            _characters[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in _characters)
        {
            go.SetActive(false);
        }
        if (_characters[index])
        {
            _characters[index].SetActive(true);
        }
        Progress.Instanse.StartLoad();
        
        //SelectVehicle();





    }

    public void SelectCheck()
    {
        if (Progress.Instanse.PlayerInfo.buybike == 1)
        {
            Destroy(_BuyBike);
        }
        if (Progress.Instanse.PlayerInfo.buyscooter == 1)
        {
            Destroy(_BuyScooter);
        }
        //SelectVehicle();
    }

    public void SelectLeft()
    {

        _characters[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = _characters.Length - 1;
        }
        _characters[index].SetActive(true);
        Debug.Log(index);
        SelectVehicle();


    }
    public void SelectRight()
    {
        _characters[index].SetActive(false);
        index++;
        if (index == _characters.Length)
        {
            index = 0;
        }
        _characters[index].SetActive(true);
        SelectVehicle();


    }
    public void StartScene()
    {
        PlayerPrefs.SetInt("SelectPlayer", index);
        SceneManager.LoadScene(1);

        
    }
    public void SelectVehicle()
    {
        if (index == 0)
        {
            _BuyBike.SetActive(false);
            _BuyScooter.SetActive(false);
            _SelectVehicle.SetActive(true);
        }
        if (index == 1)
        {
            if (Progress.Instanse.PlayerInfo.buybike == 1)
            {
                _BuyBike.SetActive(false);
                _BuyScooter.SetActive(false);
                _SelectVehicle.SetActive(true);

            }
            if (Progress.Instanse.PlayerInfo.buybike == 0)
            {
                _SelectVehicle.SetActive(false);
                _BuyScooter.SetActive(false);
                _BuyBike.SetActive(true);
            }
        }
        if (index == 2)
        {
            if (Progress.Instanse.PlayerInfo.buyscooter == 1)
            {
                _BuyScooter.SetActive(false);
                _BuyBike.SetActive(false);
                _SelectVehicle.SetActive(true);

            }
                if (Progress.Instanse.PlayerInfo.buyscooter == 0)
            {
                _SelectVehicle.SetActive(false);
                _BuyBike.SetActive(false);
                _BuyScooter.SetActive(true);
            }

        }
    }
    public void BuyBike()
    {
        if (Progress.Instanse.PlayerInfo.coins >= 5000)
        {
            Progress.Instanse.PlayerInfo.coins -= 5000;
            _BuyBike.SetActive(false);
            _SelectVehicle.SetActive(true);
            Progress.Instanse.PlayerInfo.buybike = 1;
            
            Progress.Instanse.Save();
        }

    }
    public void BuyScooter()
    {
        if (Progress.Instanse.PlayerInfo.coins >= 10000)
        {
            Progress.Instanse.PlayerInfo.coins -= 10000;
            _BuyScooter.SetActive(false);
            _SelectVehicle.SetActive(true);
            Progress.Instanse.PlayerInfo.buyscooter = 1;
            
            Progress.Instanse.Save();
        }

    }
}
