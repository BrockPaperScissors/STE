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
        Debug.Log(collider.gameObject.name + " entered range of" + this.gameObject.name);

        if (collider.gameObject.CompareTag("Player"))
        {
            playerScript.closestInteractable = this.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.name + " has exited range of " + this.gameObject.name);

        if (collider.gameObject.CompareTag("Player"))
        {

            playerScript.closestInteractable = null;
        }
    }
}
