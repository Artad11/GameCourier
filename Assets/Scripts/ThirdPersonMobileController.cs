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
        // ��������� ����� ������������ � ���������
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        // ������� ������ (�������������, ���� ������ ������� �� ����������)
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        cameraTransform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
        cameraTransform.Rotate(-mouseY * rotationSpeed * Time.deltaTime, 0, 0);
        cameraTransform.localEulerAngles = new Vector3(
            Mathf.Clamp(cameraTransform.localEulerAngles.x, 0, 20),
            cameraTransform.localEulerAngles.y,
            0
        );

        // ������� ��������� � ����������� ������
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

        // ��������, ��������� �� �������� �� �����
        isGrounded = characterController.isGrounded;
        if (isGrounded)
        {
            moveDirection = targetDirection * speed;

            // ���������� ������ (�������� ������ ������ �� UI ��� �������������)
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpSpeed;
                animator.SetTrigger("Jump");
            }

            // ���������� ���������
            animator.SetFloat("Speed", targetDirection.magnitude);
        }

        // ���������� ����������
        moveDirection.y -= gravity * Time.deltaTime;

        // �������� ���������
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
