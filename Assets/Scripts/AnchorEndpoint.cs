using UnityEngine;

public class AnchorEndpoint : MonoBehaviour
{
    public int endPointNum;
    public GameObject movingPlatform;
    public MovingPlatform movingScript;


    void Start()
    {
        movingScript = movingPlatform.GetComponent<MovingPlatform>();
        // movingScript.MoveSideToSide(1);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            if (endPointNum == 1)
            {
                movingScript.target = 2;
            }
            else if (endPointNum == 2)
            {

                movingScript.target = 1;
            }
        }
    }
}
