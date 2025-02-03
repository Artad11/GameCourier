using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonMobileController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 720.0f;
    public float gravity = 9.81f;
    public float jumpSpeed = 5.0f;
    public Joystick joystick;
    public Transform cameraTransform;

    private CharacterController characterController;
    private Animator animator;
    private Vector3 moveDirection = Vector3.zero;
    private bool isGrounded;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Получение ввода пользователя с джойстика
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        // Поворот камеры (необязательно, если камера следует за персонажем)
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        cameraTransform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
        cameraTransform.Rotate(-mouseY * rotationSpeed * Time.deltaTime, 0, 0);
        cameraTransform.localEulerAngles = new Vector3(
            Mathf.Clamp(cameraTransform.localEulerAngles.x, 0, 20),
            cameraTransform.localEulerAngles.y,
            0
        );

        // Поворот персонажа в направлении камеры
        Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
        forward.y = 0;
        forward = forward.normalized;
        Vector3 right = cameraTransform.TransformDirection(Vector3.right);
        right.y = 0;
        right = right.normalized;
        Vector3 targetDirection = horizontal * right + vertical * forward;

        if (targetDirection.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        // Проверка, находится ли персонаж на земле
        isGrounded = characterController.isGrounded;
        if (isGrounded)
        {
            moveDirection = targetDirection * speed;

            // Применение прыжка (добавьте кнопку прыжка на UI при необходимости)
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
                animator.SetTrigger("Jump");
            }

            // Управление анимацией
            animator.SetFloat("Speed", targetDirection.magnitude);
        }

        // Применение гравитации
        moveDirection.y -= gravity * Time.deltaTime;

        // Движение персонажа
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
