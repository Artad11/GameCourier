using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerControllerOnBike : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 720.0f;
    public float gravity = 9.81f;
    public float jumpSpeed = 5.0f;
   

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
        // Получение ввода пользователя
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Проверка, находится ли персонаж на земле
        isGrounded = characterController.isGrounded;
        if (isGrounded)
        {
            // Преобразование ввода в направление движения
            moveDirection = new Vector3(horizontal, 0, vertical);
            moveDirection = Vector3.ClampMagnitude(moveDirection, 1);

            // Преобразование локального направления в мировое
            moveDirection = transform.TransformDirection(moveDirection) * speed;

            // Управление анимацией
            animator.SetFloat("Speed", moveDirection.magnitude);
            

            // Применение прыжка
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
                animator.SetTrigger("Jump");
            }
        }

        // Применение гравитации
        moveDirection.y -= gravity * Time.deltaTime;

        // Движение персонажа
        characterController.Move(moveDirection * Time.deltaTime);
        

        // Поворот персонажа
        if (moveDirection.x != 0 || moveDirection.z != 0)
        {
            Vector3 targetDirection = new Vector3(moveDirection.x, 0, moveDirection.z);
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
