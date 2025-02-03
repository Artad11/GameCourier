using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CoinsOnLevel : MonoBehaviour
{
    public TextMeshProUGUI _coinsOnLevel;
    public TextMeshProUGUI _coinsOnLevelComplete;


    void Update()
    {
        _coinsOnLevel.text = CoinCollect.CoinInLevel + "";
        _coinsOnLevelComplete.text = "+" + CoinCollect.CoinInLevel;
    }
    
}
