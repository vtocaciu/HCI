using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stgoodanswer : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
    public GameObject patratst;
    public GameObject patratseringa;
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
        StartCoroutine(DelayLoadScene(4));

    }

    public IEnumerator DelayLoadScene(float seconds)
    {
        patratst.SetActive(true);

        float secondsLeft = seconds;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);
        if(patratst.activeSelf && patratseringa.activeSelf)
            SceneManager.LoadScene("OutroScene");
        else
            yield break;


    }
}
