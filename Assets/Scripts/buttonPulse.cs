using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonPulse : MonoBehaviour
{
    public Image what;
    public Color initial;
    public Color secondary;
    void Start()
    {
    }
    void Update()
    {
        what.GetComponent<Image>().color = LerpButton();

    }
    public Color LerpButton() => Color.Lerp(initial, secondary, Mathf.Sin(Time.unscaledTime * 1.25f));

}
