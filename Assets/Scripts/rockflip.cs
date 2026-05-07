using UnityEngine;

public class rockflip : MonoBehaviour
{


    public GameObject rock;
    private SpriteRenderer renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            renderer.flipX = (!renderer.flipX);
        }
    }
}
