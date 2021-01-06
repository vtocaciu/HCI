using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sectiepompiertimer : MonoBehaviour
{

    // Start is called before the first frame update
    GameObject patratfurtun;
    GameObject patratcasca;
    GameObject patratextinctor;
    GameObject patratmanusi;
    GameObject patratcizme;
    GameObject patratmasca;

    void Start()
    {
        patratfurtun = GameObject.Find("patrat-furtun"); 
        patratcasca = GameObject.Find("patrat-casca"); 
        patratextinctor = GameObject.Find("patrat-extinctor"); 
        patratmanusi = GameObject.Find("patrat-manusi"); 
        patratmasca = GameObject.Find("patrat-masca"); 
        patratcizme = GameObject.Find("patrat-cizme"); 
        GameObject.Find("patrat-furtun").SetActive(false);
        GameObject.Find("patrat-casca").SetActive(false);
        GameObject.Find("patrat-extinctor").SetActive(false);
        GameObject.Find("patrat-manusi").SetActive(false);
        GameObject.Find("patrat-cizme").SetActive(false);
        GameObject.Find("patrat-masca").SetActive(false);
        StartCoroutine(DelayLoadScene(13));
    }

    public IEnumerator DelayLoadScene(float seconds)
    {
      
        float secondsLeft = seconds;
        bool loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
            if(secondsLeft == 10.0){
                patratfurtun.SetActive(true);
            }
            if(secondsLeft == 9.0){
                patratfurtun.SetActive(false);
                patratcasca.SetActive(true);
            }
            if (secondsLeft == 7.0){
                patratcasca.SetActive(false);
                patratextinctor.SetActive(true);
            }
            if(secondsLeft == 6.0){
                patratextinctor.SetActive(false);
                patratmanusi.SetActive(true);
            }
            if(secondsLeft == 4.0){
                patratmanusi.SetActive(false);
                patratcizme.SetActive(true);
            }
            if(secondsLeft == 3.0){
                patratcizme.SetActive(false);
                patratmasca.SetActive(true);
            }
            if(secondsLeft == 1.0){
                patratmasca.SetActive(false);
            }
        } while (--secondsLeft > 0);
        
        SceneManager.LoadScene("DoctorScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
