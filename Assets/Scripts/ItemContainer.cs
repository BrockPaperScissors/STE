using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    public GameObject player;
    private Player playerScript;

    void Start()
    {
        playerScript = player.GetComponent<Player>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {


        if (collider.gameObject.CompareTag("Player"))
        {
            playerScript.closestInteractable = this.gameObject;
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
