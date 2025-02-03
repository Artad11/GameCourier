using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class TaskCompleteReward : MonoBehaviour
{
    public TextMeshProUGUI _taskReward;

     public void Add80()
    {
        _taskReward.text = "+80";
    }
     public void Add100()
    {
        _taskReward.text = "+100";
    }
     public void Add120()
    {
        _taskReward.text = "+120";
    }
}
