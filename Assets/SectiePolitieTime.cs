using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SectiePolitieTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayLoadScene(3));
    }

    public IEnumerator DelayLoadScene(float seconds)
    {
        float secondsLeft = seconds;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        SceneManager.LoadScene("IntroScene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
