using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

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
    [SerializeField]
    private Animator rocketAnimator;
    [SerializeField]
    private GameObject rocketContainer;



    IEnumerator PlayEndingAnimation()
    {
        rocketAnimator.SetTrigger("Play");

        float animLength = rocketAnimator.GetCurrentAnimatorStateInfo(0).length;

        yield return new WaitForSeconds(animLength);

        SceneManager.LoadScene("EndingWin");


    }
    void Start()
    {
        chestSprite = interactable.transform.GetChild(0).GetComponent<SpriteRenderer>();
        rocketAnimator = rocketContainer.GetComponent<Animator>();

    }

    public void OnChestOpen()
    {
        Debug.Log("Opening chest");
        chestSprite.sprite = openChest;
    }

    public void OnRocketFinished()
    {
        StartCoroutine(PlayEndingAnimation());
    }
}
