using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject leftEndpoint;
    public GameObject rightEndpoint;
    public float platformSpeed = 10f;

    public GameObject targetEndpoint;

    public void MoveSideToSide(GameObject target, int side)
    {
        if (side == 1)
        {

            transform.Translate(Vector2.left * Time.deltaTime * platformSpeed);
        }
        else
        {
            transform.Translate(Vector2.right * Time.deltaTime * platformSpeed);
        }
    }
}
