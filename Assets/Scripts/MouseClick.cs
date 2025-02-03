using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEngine.AudioSettings;
using UnityEngine.InputSystem;

public class MouseClick : MonoBehaviour
{
    [SerializeField] GameObject _mouse;
    private void Start()
    {
        if (Application.isMobilePlatform)
        {
           



        }
        else
        {
            _mouse.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !EventSystem.current.IsPointerOverGameObject())
        {

            UnityEngine.Cursor.visible = false;
        };
    }
}
