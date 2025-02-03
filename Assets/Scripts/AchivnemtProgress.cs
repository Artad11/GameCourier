using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
public class AchivnemtProgress : MonoBehaviour
{
    
    static public void offerScore()
    {
        Progress.Instanse.PlayerInfo.offerscore += 1;
    }
}
