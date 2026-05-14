using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer chestSprite;
    [SerializeField]
    private GameObject interactable;

    [SerializeField]
    private Sprite openChest;

    public GameObject rocketTop;
    public GameObject rocketNoTop;

    void Start()
    {
        chestSprite = interactable.GetComponent<SpriteRenderer>();
    }

    public void OnChestOpen()
    {
        chestSprite.sprite = openChest;
    }
}
