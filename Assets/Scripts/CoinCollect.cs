using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    static public CoinCollect Instanse;
    public static int CoinInLevel = 0;
    

    public void OnTriggerEnter(Collider other)
    {
        AddOne();
        GameObject.Find("CoinSound").GetComponent<CoinSound>().SoundPlay();
        Destroy(gameObject);
        


    }
    private void Update()
    {
        transform.Rotate(0, 180 * Time.deltaTime, 0);
    }
    public void AddOne()
    {
        CoinInLevel += 5;
       


    }
}
