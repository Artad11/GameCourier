using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]

public class PlayerInfo
{
     public int coins = 0;
     public int buybike = 0;
     public int buyscooter = 0;
     public int offerscore = 0;
     public bool offer10complete = false;
    public bool offer25complete = false;
    public bool offer50complete = false;
    public bool offer100complete = false;
    public bool offer250complete = false;
    public bool coins500complete = false;
    public bool coins1000complete = false;
    public bool coins2500complete = false;
    public bool coins5000complete = false;
    public bool coins10000complete = false;
}
public class Progress : MonoBehaviour
{
    public PlayerInfo PlayerInfo;

    [DllImport("__Internal")]
    private static extern void SaveExtern(string date);
    [DllImport("__Internal")]
    private static extern void LoadExtern();
    [DllImport("__Internal")]
    private static extern void GRAready();
    /*[DllImport("__Internal")]
    private static extern void GRAstart();
    [DllImport("__Internal")]
    private static extern void GRAstop();*/

    public static Progress Instanse;

    




    public void Save()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
        SaveExtern(jsonString);
    }

    public void SetPlayerInfo(string value)
    {
        try
        {
            PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("PlayerInfo was not set in the inspector");
        }
        //_playerInfoText.text = PlayerInfo.coins + "\n" + PlayerInfo.buybike + "\n" + PlayerInfo.buyscooter + "\n";

    }
    private void Awake()
    {
        if (Instanse == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instanse = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void StartLoad()
    {
#if UNITY_WEBGL
        LoadExtern();
        GRAready();
       
#endif



    }
    /*public void GraStartPublic()
    {
        GRAstart();
    }
    public void GraStopPublic()
    {
        GRAstop();
    }*/
    public void Update()
    {
       if (Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.lockState = CursorLockMode.None;
            UnityEngine.Cursor.visible = true;
        };
        

    }

}
