using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource _audioSource;
    public static CoinSound Instanse;
     public void SoundPlay()
    {
        _audioSource.Play();
    }
}
