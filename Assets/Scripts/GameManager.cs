using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

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
    [SerializeField]
    private GameObject mainCam;

    public GameObject playerObj;




    void Start()
    {
        chestSprite = interactable.transform.GetChild(0).GetComponent<SpriteRenderer>();
        rocketAnimator = rocketContainer.GetComponent<Animator>();
        mainCam = playerObj.transform.GetChild(0).gameObject;

    }

    IEnumerator PlayEndingAnimation()
    {
        rocketAnimator.SetTrigger("Play");

        yield return new WaitForSeconds(4.0f);

        SceneManager.LoadScene("EndingWin");


    }

    public void OnChestOpen()
    {
        Debug.Log("Opening chest");
        chestSprite.sprite = openChest;
    }

    public void OnRocketFinished()
    {

        mainCam.transform.SetParent(rocketContainer.transform, false);
        StartCoroutine(PlayEndingAnimation());
    }
}
