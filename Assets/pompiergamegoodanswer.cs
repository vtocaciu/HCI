using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pompiergamegoodanswer : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;

    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
        StartCoroutine(DelayLoadScene(4));
    }

    public IEnumerator DelayLoadScene(float seconds)
    {
        float secondsLeft = seconds;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        SceneManager.LoadScene("GhicitoareBucatar");

    }
}