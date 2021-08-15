using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseTextScroll : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //initially text1 will set active and text2, text3 set inactive
        if (Input.GetKeyDown(KeyCode.Space)) {
            text1.SetActive(false);
            text2.SetActive(true);
            /*if (Input.GetKeyDown(KeyCode.Space) && text1.activeInHierarchy == false) {
                text2.SetActive(false);
                text3.SetActive(true);
            }*/
        }
    }
}
