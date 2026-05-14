using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPlate : MonoBehaviour
{
    public Vector3 originalPos;
    bool moveBack = false;

    void Start()
    {
        originalPos = transform.position;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            transform.Translate(0, -0.2f, 0);
            moveBack = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            collision.transform.parent = transform;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            moveBack = true;
            collision.transform.parent = null;
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    private void Update()
    {
        if (moveBack)
        {
            if (transform.position.y < originalPos.y)
            {
                transform.Translate(0, 0.1f, 0);
            }
            else
            {
                moveBack = false;
            }
        }
    }
}
