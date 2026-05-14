using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SacrificeButton : MonoBehaviour
{
    IEnumerator PlayIntroAnimation()
    {
        controlAnimator.SetTrigger("Pressed");
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GrappleCaves");


    }
    private Animator controlAnimator;
    void Start()
    {
        controlAnimator = transform.parent.GetComponent<Animator>();
    }
    void OnMouseDown()
    {
        Debug.Log("Button clicked");
        StartCoroutine(PlayIntroAnimation());


    }
}
