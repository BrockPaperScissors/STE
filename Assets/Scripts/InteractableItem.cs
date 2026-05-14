using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public enum ItemList
    {
        RING,
        TROPHY,
        COIN
    }

    public ItemList item;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            switch (item)
            {
                case ItemList.RING:
                    Debug.Log("Item is: " + item);
                    break;
                case ItemList.TROPHY:
                    Debug.Log("Item is: " + item);
                    break;
                case ItemList.COIN:
                    Debug.Log("Item is: " + item);
                    break;
                default:
                    break;
            }
            Destroy(gameObject);
        }
    }
}
