using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayCar : MonoBehaviour
{
    public GameObject car;
    public float spinSpeed;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(car.name);
        car.transform.Rotate(0.0f, spinSpeed, 0.0f);
    }
}
