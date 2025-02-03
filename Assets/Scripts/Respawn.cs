using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;


public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _missionCompleted;
    [SerializeField] GameObject _deliveryUI;
    [SerializeField] GameObject  _respawnCharacter;
    [SerializeField] GameObject _respawnCamera;
    [SerializeField] GameObject _chekpoints;

    [DllImport("__Internal")]
    private static extern void ShowAdv();

    public void NewTask()
    {
        CoinCollect.CoinInLevel = 0;
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
        _missionCompleted.SetActive(false);
        ShowAdv();
        


        //_deliveryUI.SetActive(true);
        _chekpoints.SetActive(true);
    }
}
