using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    public TextMeshProUGUI _coins;
    public float coins;
    private void Start()
    {
    }
    public void Update()
    {
        coins = Progress.Instanse.PlayerInfo.coins;

        _coins.text = coins + " ";


        
    }
}
    
