using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject player;
    private Player playerScript;

    void Start()
    {
        playerScript = player.GetComponent<Player>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        Debug.Log("Object entered Rocket radius");
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered Rocket radius");
            playerScript.closestInteractable = gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerScript.closestInteractable = null;
        }
    }
}
