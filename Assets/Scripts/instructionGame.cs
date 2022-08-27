using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class instructionGame : MonoBehaviour
{
    public float duration = 4f;
    public int timeLeft;
    public GameObject aMenu;

    public void Awake()
    {
        aMenu.SetActive(true);
    }
    void Start()
    {
        aMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
        if (duration > 0)
        {
            Debug.Log(duration);
        } else
        {
            aMenu.SetActive(false);
        }


    }


}
