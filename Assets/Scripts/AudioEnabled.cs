using UnityEngine;

public class SoundRun : MonoBehaviour
{
      public AudioSource _AudioSource;
    static public SoundRun Instanse;

      public void StopAudioSource()
    {
        _AudioSource = GetComponent<AudioSource>();
        _AudioSource.Stop();
    }
}