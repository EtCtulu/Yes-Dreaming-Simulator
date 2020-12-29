using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnButtonPressTP : MonoBehaviour
{
    public Transform tpPoint;

    private Transform playerTransform;
    public GameObject _pressEText;
    private bool _isInside = false;

    private void Start()
    {
        
        _pressEText.SetActive(false);
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_isInside == true)
            {
                playerTransform.position = tpPoint.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isInside = true;
        _pressEText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        _isInside = false;
        _pressEText.SetActive(false);
    }
}
