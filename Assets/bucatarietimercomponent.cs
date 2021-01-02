using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bucatarietimercomponent : MonoBehaviour
{

    // Start is called before the first frame update
    GameObject patratOala;
    GameObject patratTigaie;
    GameObject patratCutit;
    GameObject patratTocator;
    GameObject patratMixer;
    GameObject patratLingura;

    void Start()
    {
        patratOala = GameObject.Find("patrat-oala"); 
        patratTigaie = GameObject.Find("patrat-tigaie"); 
        patratCutit = GameObject.Find("patrat-cutit"); 
        patratTocator = GameObject.Find("patrat-tocator"); 
        patratLingura = GameObject.Find("patrat-lingura"); 
        patratMixer = GameObject.Find("patrat-mixer"); 
        GameObject.Find("patrat-oala").SetActive(false);
        GameObject.Find("patrat-tigaie").SetActive(false);
        GameObject.Find("patrat-cutit").SetActive(false);
        GameObject.Find("patrat-tocator").SetActive(false);
        GameObject.Find("patrat-mixer").SetActive(false);
        GameObject.Find("patrat-lingura").SetActive(false);
        StartCoroutine(DelayLoadScene(12));
    }

    public IEnumerator DelayLoadScene(float seconds)
    {
      
        float secondsLeft = seconds;
        bool loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
            if(secondsLeft == 10.0){
                patratOala.SetActive(true);
            }
            if(secondsLeft == 9.0){
                patratOala.SetActive(false);
                patratTigaie.SetActive(true);
            }
            if (secondsLeft == 8.0){
                patratTigaie.SetActive(false);
            }
            if(secondsLeft == 7.0){
                patratCutit.SetActive(true);
            }
            if(secondsLeft == 6.0){
                patratCutit.SetActive(false);
                patratTocator.SetActive(true);
            }
            if(secondsLeft == 5.0){
                patratTocator.SetActive(false);
                patratMixer.SetActive(true);
            }
            if(secondsLeft == 4.0){
                patratMixer.SetActive(false);
                patratLingura.SetActive(true);
            }
            if(secondsLeft == 3.0){
                patratLingura.SetActive(false);
            }
        } while (--secondsLeft > 0);
        
        SceneManager.LoadScene("PolitistScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
