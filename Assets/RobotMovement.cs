using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RobotMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 720f;

    private Rigidbody rb;
    private Animator animator;
    private Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        moveDirection = new Vector3(h, 0f, v).normalized;

        if (moveDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, turnSpeed * Time.deltaTime);
        }

        if (animator != null)
        {
            animator.SetFloat("Speed", moveDirection.magnitude);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
