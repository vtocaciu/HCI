using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class timercomponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayLoadScene(6));
    }

    public IEnumerator DelayLoadScene(float seconds)
    {
        float secondsLeft = seconds;
        bool loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        SceneManager.LoadScene("New Scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
