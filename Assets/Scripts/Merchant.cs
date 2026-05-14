using UnityEngine;

public class Merchant : MonoBehaviour
{
    public GameObject player;
    private Player playerScript;

    void Start()
    {
        playerScript = player.GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Object entered merchant radius");
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered merchant radius");
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
