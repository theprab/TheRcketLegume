using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPulse : MonoBehaviour
{

    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, Mathf.PingPong(Time.time * 10, 3), transform.localScale.z);
    }

}
