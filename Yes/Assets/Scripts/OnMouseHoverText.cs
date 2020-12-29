using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMouseHoverText : MonoBehaviour
{
    private Text text;
    public Color trans = new Color(255, 255,255, 150);

    private void Start()
    {
        text = GetComponentInChildren<Text>();
        text.color = new Color(255, 255, 255, 150);
    }

    void Update()
    {
        text.color = new Color(255, 255, 255, 150);
    }

    private void OnMouseOver()
    {
        text.color = new Color(255, 255, 255, 255);
    }

    private void OnMouseEnter()
    {
        text.color = new Color(255, 255, 255, 255);
    }
}
