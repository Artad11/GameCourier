using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class SwitchLanguage : MonoBehaviour
{
    public TextMeshProUGUI _play;
    public TextMeshProUGUI _achivments;

    public void English()
    {
        _play.text = "PLAY";
        _achivments.text = "Achivments";
    }
}
