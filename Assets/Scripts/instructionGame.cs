using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class instructionGame : MonoBehaviour
{
    public float duration = 4f;
    public int timeLeft;
    public GameObject aMenu;
<<<<<<< Updated upstream:Assets/Scripts/instructionGame.cs

    public void Awake()
=======
    public bool isStarted = false;
    public int keyPressCount = 0;
    void Awake()
>>>>>>> Stashed changes:Assets/Scripts/startInstruction.cs
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
<<<<<<< Updated upstream:Assets/Scripts/instructionGame.cs
        if (duration > 0)
        {
            Debug.Log(duration);
        } else
=======
        Debug.Log(duration);
        while(keyPressCount <= 2)
        {
            //Debug.Log("key down" + Input.GetKeyDown(KeyCode.Escape));
            Debug.Log("keyPressCount before" + keyPressCount);
            if (Input.GetKeyDown(KeyCode.Escape) && Input.GetKeyUp(KeyCode.Escape)) { keyPressCount++; }
            Debug.Log("keyPressCount after" + keyPressCount);
        }
        if (duration <= 0 || Input.GetKeyDown(KeyCode.Space)) {
            aMenu.SetActive(false);
            isStarted = true;
        }
        if (isStarted)
>>>>>>> Stashed changes:Assets/Scripts/startInstruction.cs
        {
            aMenu.SetActive(false);
        }


    }


}
