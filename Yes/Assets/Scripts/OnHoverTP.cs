using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverTP : MonoBehaviour
{
    
    public Transform tpPoint;

    private Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        playerTransform.position = tpPoint.position;
    }
}
