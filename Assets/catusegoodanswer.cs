using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class catusegoodanswer : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
    public GameObject patratcatuse;
    public GameObject patratins;
    public GameObject patratmasina;
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
        StartCoroutine(DelayLoadScene(4));

    }

    public IEnumerator DelayLoadScene(float seconds)
    {
        patratcatuse.SetActive(true);

        float secondsLeft = seconds;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);
        if(patratcatuse.activeSelf && patratins.activeSelf && patratmasina.activeSelf)
            SceneManager.LoadScene("GhicitoareDoctor");
        else
            yield break;


    }
}
