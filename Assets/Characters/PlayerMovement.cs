using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ZeroBit"))
        {
            // Collect 0-bit
            Destroy(other.gameObject);
            Debug.Log("Collected 0-bit!");
        }
        else if (other.CompareTag("WrongBit"))
        {
            Debug.Log("Wrong bit! Pushed back or penalized!");
            // Implement your penalty logic
        }
        else if (other.CompareTag("Virus"))
        {
            Debug.Log("Caught by the virus!");
            SceneManager.LoadScene("GameOverScene"); // Replace with your actual game over scene
        }
    }
}
