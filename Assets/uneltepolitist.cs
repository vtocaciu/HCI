using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uneltepolitist : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("patrat-ins").SetActive(false);
        GameObject.Find("patrat-catuse").SetActive(false);
        GameObject.Find("patrat-masina").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
