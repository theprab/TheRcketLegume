using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cpuMovement : MonoBehaviour
{
    public GameObject earth;
    void Start()
    {
        earth = GameObject.FindWithTag("ball");
    }

    // Update is called once per frame
    void Update()
    {
        float n = Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, earth.transform.position, n);
        if (Vector3.Distance(transform.position, earth.transform.position) < 0.001f) {
            earth.transform.position *= -1.0f; 
        }
    }
}
