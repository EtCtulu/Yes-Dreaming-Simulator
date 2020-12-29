using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPBed : MonoBehaviour
{
    public GameObject sleepCamera;
    public GameObject player;
    public int sceneNumber = 2;

    private bool _isInside;
    private GameObject _pressEText;

    private void Start()
    {
        _pressEText = GameObject.FindGameObjectWithTag("Press E");
        _pressEText.SetActive(false);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_isInside == true)
            {
                Destroy(player);
                sleepCamera.SetActive(true);
                StartCoroutine(tp());
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

    private IEnumerator tp()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(sceneNumber);
    }
}
