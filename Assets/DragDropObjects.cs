﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropObjects : MonoBehaviour
{
    public void Red()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Black()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }

    private bool IsHeld;
    private GameObject Reticle;
    // Start is called before the first frame update
    void Start()
    {
        IsHeld = false;
        GetComponent<Renderer>().material.color = new Color(0.9056604f, 0.5189343f, 0.2947668f, 1f);
        //0.2274491f, 0.6509434f, 0.1443129f, 1f green
        //0.9056604f, 0.5189343f, 0.2947668f, 1f orange
        //0.764151f, 0.08950541f, 0.08290318f, 1f red
        Reticle = GameObject.Find("GvrReticlePointer (1)");
    }

    public void PaintItGreen()
    {
        IsHeld = false;
        GameObject.Find("Cube").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        GameObject.Find("Cube (1)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        GameObject.Find("Cube (2)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        GameObject.Find("Cube (3)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        GameObject.Find("Cube (5)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        GameObject.Find("Cube (8)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        GameObject.Find("Cube (8)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        //0.2274491f, 0.6509434f, 0.1443129f, 1f green
        //0.9056604f, 0.5189343f, 0.2947668f, 1f orange
        //0.764151f, 0.08950541f, 0.08290318f, 1f red
        Reticle = GameObject.Find("GvrReticlePointer (1)");
    }
    public void PaintItRed()
    {
        IsHeld = false;
        GameObject.Find("Cube").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GameObject.Find("Cube (1)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GameObject.Find("Cube (2)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GameObject.Find("Cube (3)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GameObject.Find("Cube (5)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GameObject.Find("Cube (8)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GameObject.Find("Cube (8)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        //0.2274491f, 0.6509434f, 0.1443129f, 1f green
        //0.9056604f, 0.5189343f, 0.2947668f, 1f orange
        //0.764151f, 0.08950541f, 0.08290318f, 1f red
        Reticle = GameObject.Find("GvrReticlePointer (1)");
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHeld)
        {
            Ray ray = new Ray(Reticle.transform.position, Reticle.transform.forward);
            transform.position = ray.GetPoint(4);
        }

    }

    public void HandleGazeTriggerStart()
    {
        IsHeld = true;
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void HandleGazeTriggerEnd()
    {
        IsHeld = false;
        GetComponent<Renderer>().material.color = new Color(0.9056604f, 0.5189343f, 0.2947668f, 1f);

    }

//    public void OnHover()
//    {
//        GetComponent<Renderer>().material.color = new Color(0.8056604f, 0.5189343f, 0.2947668f, 1f);
//    }
//
//    public void OnHoverExit()
//    {
//        GetComponent<Renderer>().material.color = new Color(0.9056604f, 0.5189343f, 0.2947668f, 1f);
//    }

}
