using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D rb;
    public float moveSpeed = 10;
    public float jumpForce = 100f;
    private bool isGrounded = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right * Time.deltaTime) * moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left * Time.deltaTime) * moveSpeed;
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {


            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);

            isGrounded = false;

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Hit the ground");
            isGrounded = true;
        }
    }
}
