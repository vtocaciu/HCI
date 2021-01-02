using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spitaltimer : MonoBehaviour
{
    GameObject patratmedicamente;
    GameObject patratplasture;
    GameObject patratbisturiu;
    GameObject patrattermometru;
    GameObject patratinjectie;
    GameObject patratstetoscop;

    // Start is called before the first frame update
    void Start()
    {
        patratmedicamente = GameObject.Find("patrat-medicamente"); 
        patratplasture = GameObject.Find("patrat-plasture"); 
        patratbisturiu = GameObject.Find("patrat-bisturiu"); 
        patrattermometru = GameObject.Find("patrat-termometru"); 
        patratstetoscop = GameObject.Find("patrat-stetoscop"); 
        patratinjectie = GameObject.Find("patrat-injectie"); 

        GameObject.Find("patrat-medicamente").SetActive(false);
        GameObject.Find("patrat-plasture").SetActive(false);
        GameObject.Find("patrat-bisturiu").SetActive(false);
        GameObject.Find("patrat-termometru").SetActive(false);
        GameObject.Find("patrat-injectie").SetActive(false);
        GameObject.Find("patrat-stetoscop").SetActive(false);

        StartCoroutine(DelayLoadScene(11));
    }

    public IEnumerator DelayLoadScene(float seconds)
    {
        float secondsLeft = seconds;
        do
        {
            yield return new WaitForSeconds(1);
            if(secondsLeft == 10.0){
                patratstetoscop.SetActive(true);
            }
            if(secondsLeft == 9.0){
                patratstetoscop.SetActive(false);
                patratinjectie.SetActive(true);
            }
            if (secondsLeft == 7.0){
                patratinjectie.SetActive(false);
                patrattermometru.SetActive(true);
            }
            if(secondsLeft == 6.0){
                patrattermometru.SetActive(false);
                patratmedicamente.SetActive(true);
            }
            if(secondsLeft == 4.0){
                patratmedicamente.SetActive(false);
                patratplasture.SetActive(true);
            }
            if(secondsLeft == 3.0){
                patratplasture.SetActive(false);
                patratbisturiu.SetActive(true);
            }
            if(secondsLeft == 2.0){
                patratbisturiu.SetActive(false);
            }
        } while (--secondsLeft > 0);


        SceneManager.LoadScene("BucatarGame");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
