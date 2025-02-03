using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    
    public FixedJoystick joystick;
    public float SpeedMove = 5f;
    private CharacterController controller;
    [SerializeField] Animator animator;
    Vector3 moveDirection = Vector3.zero;
    void Start()
    {
        controller= GetComponent<CharacterController>();
    }

    
    void Update()
    {
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        controller.Move(Move * SpeedMove * Time.deltaTime);
        animator.SetFloat("Speed", moveDirection.magnitude);
    }
}
