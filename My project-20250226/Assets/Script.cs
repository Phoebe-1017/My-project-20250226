using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Frist Start");
    }

    private void Awake()
    {
        Debug.Log(message:"Awake");
    }

    private void OnEnable()
    {
        Debug.Log(message:"OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log(message:"OnDisable");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(message:"OnTriggerEnter2D");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(message:"OnCollisionEnter2D");
    }
}