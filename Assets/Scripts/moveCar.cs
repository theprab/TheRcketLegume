using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour
{
    Rigidbody car;
    public float drivingForce = 250f;
    void Start()
    {
        car = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 80, 0);
        car.AddForce(this.transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * drivingForce);

        //boost
        if (Input.GetMouseButtonDown(0))
        {
            car.AddForce(this.transform.forward * Input.GetAxis("Vertical") * drivingForce / 1.5f);
        }

        //jump
        if (Input.GetMouseButtonDown(1) && car.position.y <= 0.02) {
            car.AddForce(transform.up * 500);
        }
    }
}