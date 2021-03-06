﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{

    public Color hoverColor;

    private Renderer rend;
    private Color startColor;
    public GameObject highlightedObject;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        //rend.material.color = hoverColor;

    }

    void OnMouseDown()
    {
        highlightedObject = gameObject;
        Destroy(highlightedObject);
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
