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
    [SerializeField]
    private GameObject rocketCam;



    IEnumerator PlayEndingAnimation()
    {
        mainCam.SetActive(false);
        rocketCam.SetActive(true);
        rocketAnimator.SetTrigger("Play");


        yield return new WaitForSeconds(4.0f);

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
