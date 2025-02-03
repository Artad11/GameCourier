using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;




public class Checkpoint : MonoBehaviour
{
    public static bool _missionCompletedcheck = false;
    [SerializeField] GameObject _missionCompleted;
    [SerializeField] GameObject _chekpoint;
    [SerializeField] GameObject _missionFailed;
    [SerializeField] GameObject _pause;
    [SerializeField] GameObject _audioTest;
    private SC_TPSController _TPSController;
    private SC_CameraCollision _SC_CameraCollision;
    private AudioListener _AudioListener;
    
    static public Checkpoint Instance;

    

    public void OnTriggerEnter(Collider other)
    {
        if (NewDelivery.TimeSkip == false)
        {
            AchivnemtProgress.offerScore();
            _audioTest.SetActive(true);
            _pause.SetActive(false);
            _missionFailed.SetActive(true);
            _chekpoint.SetActive(false);
            NewDelivery.StopTimer();
            Time.timeScale = 0f;
            _missionCompletedcheck = true;
            Cursor.lockState = CursorLockMode.None;
            UnityEngine.Cursor.visible = true;

            Progress.Instanse.Save();
            CameraAndSoundStop();
            NewDelivery.TimeSkip = true;
            AudioListener.pause = true;
        }
        else
        {
            AchivnemtProgress.offerScore();
            _audioTest.SetActive(true);
            _pause.SetActive(false);
            _missionCompleted.SetActive(true);
            _chekpoint.SetActive(false);
            NewDelivery.StopTimer();
            CoinsPlus100();
            Time.timeScale = 0f;
            _missionCompletedcheck = true;
            Cursor.lockState = CursorLockMode.None;
            UnityEngine.Cursor.visible = true;
            CameraAndSoundStop();
            AudioListener.pause = true;


            Progress.Instanse.Save();
            

        }
        


    }
    public void CoinsPlus100()
    {
        

        if (ChekpointManager.Level == 1)
        {
            //GameObject.Find("TaskComleteReward").GetComponent<TaskCompleteReward>().Add80();
            Progress.Instanse.PlayerInfo.coins += 80;
            
            Progress.Instanse.PlayerInfo.coins += CoinCollect.CoinInLevel;


            NewDelivery.TimeSkip = true;
        }
        if (ChekpointManager.Level == 2)
        {
            Progress.Instanse.PlayerInfo.coins += 100;
            Progress.Instanse.PlayerInfo.coins += CoinCollect.CoinInLevel;
            //GameObject.Find("TaskComleteReward").GetComponent<TaskCompleteReward>().Add100();

            NewDelivery.TimeSkip = true;
        }
        if (ChekpointManager.Level == 3)
        {
            Progress.Instanse.PlayerInfo.coins += 120;
            Progress.Instanse.PlayerInfo.coins += CoinCollect.CoinInLevel;
            //GameObject.Find("TaskComleteReward").GetComponent<TaskCompleteReward>().Add120();
            NewDelivery.TimeSkip = true;
        }
        



    }
    public void CameraAndSoundStop()
    {
        _TPSController = FindObjectOfType<SC_TPSController>();
        _TPSController.enabled = false;
        _SC_CameraCollision = FindObjectOfType<SC_CameraCollision>();
        _SC_CameraCollision.enabled = false;
        _AudioListener = FindObjectOfType<AudioListener>();
        _AudioListener.enabled = false;
    }
    
     
}

