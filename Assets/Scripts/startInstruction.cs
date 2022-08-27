using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startInstruction : MonoBehaviour
{
    public float duration = 3f;
    public GameObject aMenu;
    public bool isStarted = false;
    void Awake()
    {
        aMenu.SetActive(true);
    }
    void Start()
    {
        aMenu.SetActive(true);
        isStarted = false;
    }
    // Update is called once per frame
    void Update()
    {
        duration -= Time.deltaTime;
        Debug.Log(duration);
        if (duration <= 0 || Input.GetKeyDown(KeyCode.Space)) {
            aMenu.SetActive(false);
            isStarted = true;
        }
        if (isStarted)
        {
            aMenu.SetActive(false);
        }
    }
}
