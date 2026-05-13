using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject leftEndpoint;
    public GameObject rightEndpoint;

    public int target = 0;
    public float platformSpeed = 10f;

    void Update()
    {
        MoveSideToSide(target);
    }

    public void MoveSideToSide(int target)
    {
        if (target == 1)
        {

            transform.Translate(Vector2.left * Time.deltaTime * platformSpeed);
        }
        else
        {
            transform.Translate(Vector2.right * Time.deltaTime * platformSpeed);
        }
    }
}
