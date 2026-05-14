using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D rb;
    public float moveSpeed = 10;
    public float jumpForce = 100f;
    public float grappleSpeed = 20f;
    private bool isGrounded = false;
    private bool canGrapple = true;
    private bool canMove = true;
    public GameObject closestInteractable;
    private Vector2 playerPos;
    private GameObject castPoint;
    private Vector2 clickPos = new Vector2(0, 0);
    private Vector2 grappleDir;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        castPoint = GameObject.Find("CastPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
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

            if (Input.GetMouseButtonDown(1) && isGrounded)
            {

                GrappleMove();
            }
        }

        if (!canGrapple)
        {
            rb.MovePosition(rb.position + grappleDir * Time.deltaTime * grappleSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Hit the ground");
            isGrounded = true;
            canGrapple = true;
            canMove = true;

        }
    }

    void GrappleMove()
    {
        Debug.Log("right mouse button down clicked");
        clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        playerPos = (Vector2)castPoint.transform.position;
        grappleDir = (clickPos - playerPos).normalized;

        int groundMask = LayerMask.GetMask("Ground");
        RaycastHit2D hit = Physics2D.Raycast(clickPos, playerPos, 100f, groundMask);

        if (hit.collider)
        {
            Debug.Log("Hit  " + hit.collider.gameObject.name);

            switch (hit.collider.gameObject.tag)
            {
                case ("Ground"):

                    Debug.Log("Grappling hit ground object");
                    canGrapple = false;
                    isGrounded = false;
                    canMove = false;

                    break;
                default:
                    break;
            }
        }
    }

}
