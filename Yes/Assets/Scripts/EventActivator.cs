using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventActivator : MonoBehaviour
{

    public GameObject theEvent;
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        theEvent.SetActive(true);
        GameManager._instance.Coroutine();
        Destroy(gameObject);
    }
}
