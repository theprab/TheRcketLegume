using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayCar : MonoBehaviour
{
    Vector3 initialPos = new Vector3();
    void Start()
    {
        initialPos = transform.position; //need this initial position for later
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Time.deltaTime * 50, 0.0f);
    }
}
