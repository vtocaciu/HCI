using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SectiePolitieTime : MonoBehaviour
{
    GameObject patratLanterna;
    GameObject patratInsigna;
    GameObject patratMegafon;
    GameObject patratMasina;
    GameObject patratBaston;
    GameObject patratCatuse;

    // Start is called before the first frame update
    void Start()
    {
        patratLanterna = GameObject.Find("patrat-lanterna"); 
        patratInsigna = GameObject.Find("patrat-insigna"); 
        patratMegafon = GameObject.Find("patrat-megafon"); 
        patratMasina = GameObject.Find("patrat-masina"); 
        patratCatuse = GameObject.Find("patrat-catuse"); 
        patratBaston = GameObject.Find("patrat-baston"); 

        GameObject.Find("patrat-lanterna").SetActive(false);
        GameObject.Find("patrat-insigna").SetActive(false);
        GameObject.Find("patrat-megafon").SetActive(false);
        GameObject.Find("patrat-masina").SetActive(false);
        GameObject.Find("patrat-baston").SetActive(false);
        GameObject.Find("patrat-catuse").SetActive(false);

        StartCoroutine(DelayLoadScene(11));
    }

    public IEnumerator DelayLoadScene(float seconds)
    {
        float secondsLeft = seconds;
        do
        {
            yield return new WaitForSeconds(1);
            if(secondsLeft == 8.0){
                patratCatuse.SetActive(true);
            }
            if(secondsLeft == 7.0){
                patratCatuse.SetActive(false);
                patratBaston.SetActive(true);
            }
            if (secondsLeft == 6.0){
                patratBaston.SetActive(false);
                patratMasina.SetActive(true);
            }
            if(secondsLeft == 5.0){
                patratMasina.SetActive(false);
                patratLanterna.SetActive(true);
            }
            if(secondsLeft == 4.0){
                patratLanterna.SetActive(false);
                patratInsigna.SetActive(true);
            }
            if(secondsLeft == 3.0){
                patratInsigna.SetActive(false);
                patratMegafon.SetActive(true);
            }
            if(secondsLeft == 2.0){
                patratMegafon.SetActive(false);
            }
        } while (--secondsLeft > 0);

        SceneManager.LoadScene("PompierScene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
