using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class AchivmentScore : MonoBehaviour
{
    public TextMeshProUGUI _offer10;
    [SerializeField] GameObject _offer10GO;
    [SerializeField] GameObject _completeoffer10;
    [SerializeField] GameObject _rewardoffer10;
    [SerializeField] GameObject _pickupoffer10;
    [SerializeField] GameObject _receivedffer10;

    public TextMeshProUGUI _offer25;
    [SerializeField] GameObject _offer25GO;
    [SerializeField] GameObject _completeoffer25;
    [SerializeField] GameObject _rewardoffer25;
    [SerializeField] GameObject _pickupoffer25;
    [SerializeField] GameObject _receivedffer25;

    public TextMeshProUGUI _offer50;
    [SerializeField] GameObject _offer50GO;
    [SerializeField] GameObject _completeoffer50;
    [SerializeField] GameObject _rewardoffer50;
    [SerializeField] GameObject _pickupoffer50;
    [SerializeField] GameObject _receivedffer50;

    public TextMeshProUGUI _offer100;
    [SerializeField] GameObject _offer100GO;
    [SerializeField] GameObject _completeoffer100;
    [SerializeField] GameObject _rewardoffer100;
    [SerializeField] GameObject _pickupoffer100;
    [SerializeField] GameObject _receivedffer100;

    public TextMeshProUGUI _offer250;
    [SerializeField] GameObject _offer250GO;
    [SerializeField] GameObject _completeoffer250;
    [SerializeField] GameObject _rewardoffer250;
    [SerializeField] GameObject _pickupoffer250;
    [SerializeField] GameObject _receivedffer250;

    public TextMeshProUGUI _coins500;
    [SerializeField] GameObject _coins500GO;
    [SerializeField] GameObject _completecoins500;
    [SerializeField] GameObject _rewardcoins500;
    [SerializeField] GameObject _pickupcoins500;
    [SerializeField] GameObject _receivedcoins500;

    public TextMeshProUGUI _coins1000;
    [SerializeField] GameObject _coins1000GO;
    [SerializeField] GameObject _completecoins1000;
    [SerializeField] GameObject _rewardcoins1000;
    [SerializeField] GameObject _pickupcoins1000;
    [SerializeField] GameObject _receivedcoins1000;

    public TextMeshProUGUI _coins2500;
    [SerializeField] GameObject _coins2500GO;
    [SerializeField] GameObject _completecoins2500;
    [SerializeField] GameObject _rewardcoins2500;
    [SerializeField] GameObject _pickupcoins2500;
    [SerializeField] GameObject _receivedcoins2500;

    public TextMeshProUGUI _coins5000;
    [SerializeField] GameObject _coins5000GO;
    [SerializeField] GameObject _completecoins5000;
    [SerializeField] GameObject _rewardcoins5000;
    [SerializeField] GameObject _pickupcoins5000;
    [SerializeField] GameObject _receivedcoins5000;

    public TextMeshProUGUI _coins10000;
    [SerializeField] GameObject _coins10000GO;
    [SerializeField] GameObject _completecoins10000;
    [SerializeField] GameObject _rewardcoins10000;
    [SerializeField] GameObject _pickupcoins10000;
    [SerializeField] GameObject _receivedcoins10000;

    private void Update()
    {
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.offerscore >= 10)
        {
            _completeoffer10.SetActive(true);
            _offer10GO.SetActive(false);
            _pickupoffer10.SetActive(true);

        }
        else
        {
            _rewardoffer10.SetActive(true);
            _offer10.text = Progress.Instanse.PlayerInfo.offerscore + "/10";
        }
        if (Progress.Instanse.PlayerInfo.offer10complete == true)
        {
            _receivedffer10.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.offerscore >= 25)
        {
            _completeoffer25.SetActive(true);
            _offer25GO.SetActive(false);
            _pickupoffer25.SetActive(true);

        }
        else
        {
            _rewardoffer25.SetActive(true);
            _offer25.text = Progress.Instanse.PlayerInfo.offerscore + "/25";
        }
        if (Progress.Instanse.PlayerInfo.offer25complete == true)
        {
            _receivedffer25.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.offerscore >= 50)
        {
            _completeoffer50.SetActive(true);
            _offer50GO.SetActive(false);
            _pickupoffer50.SetActive(true);

        }
        else
        {
            _rewardoffer50.SetActive(true);
            _offer50.text = Progress.Instanse.PlayerInfo.offerscore + "/50";
        }
        if (Progress.Instanse.PlayerInfo.offer50complete == true)
        {
            _receivedffer50.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.offerscore >= 100)
        {
            _completeoffer100.SetActive(true);
            _offer100GO.SetActive(false);
            _pickupoffer100.SetActive(true);

        }
        else
        {
            _rewardoffer100.SetActive(true);
            _offer100.text = Progress.Instanse.PlayerInfo.offerscore + "/100";
        }
        if (Progress.Instanse.PlayerInfo.offer100complete == true)
        {
            _receivedffer100.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.offerscore >= 250)
        {
            _completeoffer250.SetActive(true);
            _offer250GO.SetActive(false);
            _pickupoffer250.SetActive(true);

        }
        else
        {
            _rewardoffer250.SetActive(true);
            _offer250.text = Progress.Instanse.PlayerInfo.offerscore + "/250";
        }
        if (Progress.Instanse.PlayerInfo.offer250complete == true)
        {
            _receivedffer250.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.coins >= 500)
        {
            _completecoins500.SetActive(true);
            _coins500GO.SetActive(false);
            _pickupcoins500.SetActive(true);

        }
        else
        {
            _rewardcoins500.SetActive(true);
            _coins500.text = Progress.Instanse.PlayerInfo.coins + "/500";
        }
        if (Progress.Instanse.PlayerInfo.coins500complete == true)
        {
            _receivedcoins500.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.coins >= 1000)
        {
            _completecoins1000.SetActive(true);
            _coins1000GO.SetActive(false);
            _pickupcoins1000.SetActive(true);

        }
        else
        {
            _rewardcoins1000.SetActive(true);
            _coins1000.text = Progress.Instanse.PlayerInfo.coins + "/1000";
        }
        if (Progress.Instanse.PlayerInfo.coins1000complete == true)
        {
            _receivedcoins1000.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.coins >= 2500)
        {
            _completecoins2500.SetActive(true);
            _coins2500GO.SetActive(false);
            _pickupcoins2500.SetActive(true);

        }
        else
        {
            _rewardcoins2500.SetActive(true);
            _coins2500.text = Progress.Instanse.PlayerInfo.coins + "/2500";
        }
        if (Progress.Instanse.PlayerInfo.coins2500complete == true)
        {
            _receivedcoins2500.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.coins >= 5000)
        {
            _completecoins5000.SetActive(true);
            _coins5000GO.SetActive(false);
            _pickupcoins5000.SetActive(true);

        }
        else
        {
            _rewardcoins5000.SetActive(true);
            _coins5000.text = Progress.Instanse.PlayerInfo.coins + "/5000";
        }
        if (Progress.Instanse.PlayerInfo.coins5000complete == true)
        {
            _receivedcoins5000.SetActive(true);
        }
        /////////////////////////////////////////////////////
        if (Progress.Instanse.PlayerInfo.coins >= 10000)
        {
            _completecoins10000.SetActive(true);
            _coins10000GO.SetActive(false);
            _pickupcoins10000.SetActive(true);

        }
        else
        {
            _rewardcoins10000.SetActive(true);
            _coins10000.text = Progress.Instanse.PlayerInfo.coins + "/10000";
        }
        if (Progress.Instanse.PlayerInfo.coins10000complete == true)
        {
            _receivedcoins10000.SetActive(true);
        }


    }
    public void receivedffer10()
    {
        Destroy(_pickupoffer10);
        _receivedffer10.SetActive(true);
        Offer10complete();
        Progress.Instanse.PlayerInfo.coins += 250;
        Progress.Instanse.Save();
    }
    public static bool Offer10complete()
    {
        return Progress.Instanse.PlayerInfo.offer10complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedffer25()
    {
        Destroy(_pickupoffer25);
        _receivedffer25.SetActive(true);
        Offer25complete();
        Progress.Instanse.PlayerInfo.coins += 500;
        Progress.Instanse.Save();
    }
    public static bool Offer25complete()
    {
        return Progress.Instanse.PlayerInfo.offer25complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedffer50()
    {
        Destroy(_pickupoffer50);
        _receivedffer50.SetActive(true);
        Offer50complete();
        Progress.Instanse.PlayerInfo.coins += 1000;
        Progress.Instanse.Save();
    }
    public static bool Offer50complete()
    {
        return Progress.Instanse.PlayerInfo.offer50complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedffer100()
    {
        Destroy(_pickupoffer100);
        _receivedffer100.SetActive(true);
        Offer100complete();
        Progress.Instanse.PlayerInfo.coins += 2500;
        Progress.Instanse.Save();
    }
    public static bool Offer100complete()
    {
        return Progress.Instanse.PlayerInfo.offer100complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedffer250()
    {
        Destroy(_pickupoffer250);
        _receivedffer250.SetActive(true);
        Offer250complete();
        Progress.Instanse.PlayerInfo.coins += 5000;
        Progress.Instanse.Save();
    }
    public static bool Offer250complete()
    {
        return Progress.Instanse.PlayerInfo.offer250complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedcoins500()
    {
        Destroy(_pickupcoins500);
        _receivedcoins500.SetActive(true);
        Coins500complete();
        Progress.Instanse.PlayerInfo.coins += 100;
        Progress.Instanse.Save();
    }
    public static bool Coins500complete()
    {
        return Progress.Instanse.PlayerInfo.coins500complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedcoins1000()
    {
        Destroy(_pickupcoins1000);
        _receivedcoins1000.SetActive(true);
        Coins1000complete();
        Progress.Instanse.PlayerInfo.coins += 200;
        Progress.Instanse.Save();
    }
    public static bool Coins1000complete()
    {
        return Progress.Instanse.PlayerInfo.coins1000complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedcoins2500()
    {
        Destroy(_pickupcoins2500);
        _receivedcoins2500.SetActive(true);
        Coins2500complete();
        Progress.Instanse.PlayerInfo.coins += 500;
        Progress.Instanse.Save();
    }
    public static bool Coins2500complete()
    {
        return Progress.Instanse.PlayerInfo.coins2500complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedcoins5000()
    {
        Destroy(_pickupcoins5000);
        _receivedcoins5000.SetActive(true);
        Coins5000complete();
        Progress.Instanse.PlayerInfo.coins += 1000;
        Progress.Instanse.Save();
    }
    public static bool Coins5000complete()
    {
        return Progress.Instanse.PlayerInfo.coins5000complete = true;
    }
    /////////////////////////////////////////////////////
    public void receivedcoins10000()
    {
        Destroy(_pickupcoins10000);
        _receivedcoins10000.SetActive(true);
        Coins10000complete();
        Progress.Instanse.PlayerInfo.coins += 2000;
        Progress.Instanse.Save();
    }
    public static bool Coins10000complete()
    {
        return Progress.Instanse.PlayerInfo.coins10000complete = true;
    }


}
