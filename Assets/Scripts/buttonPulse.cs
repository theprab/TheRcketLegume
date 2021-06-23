using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPulse : MonoBehaviour
{
    float scaleInOut;
    float speed = 3f;
    float depth = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scaleInOut = Mathf.Sin(Time.time * speed);
        transform.localScale = new Vector3(scaleInOut, scaleInOut, scaleInOut) * depth;
    }
}
