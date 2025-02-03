using UnityEngine;

public class CarCrash : MonoBehaviour
{
    [SerializeField] GameObject _car;
    [SerializeField] GameObject _pause;
    [SerializeField] GameObject _audioTest;
    private SC_TPSController _TPSController;
    private SC_CameraCollision _SC_CameraCollision;
    private AudioListener _AudioListener;
    private AudioSource _AudioSource;




    private void OnTriggerEnter(Collider other)
    {

        _audioTest.SetActive(true);
        _car.SetActive(true);
        Progress.Instanse.PlayerInfo.coins -= 100;

        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;
        AudioListener.pause = true;
        _pause.SetActive(false);
        _TPSController = FindObjectOfType<SC_TPSController>();
        _TPSController.enabled = false;
        _SC_CameraCollision = FindObjectOfType<SC_CameraCollision>();
        _SC_CameraCollision.enabled = false;
        _AudioListener = FindObjectOfType<AudioListener>();
        _AudioListener.enabled = false;
        _AudioSource = FindObjectOfType<AudioSource>();
        _AudioSource.enabled = false;

        Progress.Instanse.Save();


    }



}
