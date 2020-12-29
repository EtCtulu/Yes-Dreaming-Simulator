using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    private static GameManager _instance;

    private int _eventDid = 0;
    private GameObject _eventDidDraw;
    private Text _eventDidDrawText;
    
    void Start()
    {
        
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
            _eventDidDraw = GameObject.FindGameObjectWithTag("TextEvent");
            _eventDidDrawText = _eventDidDraw.GetComponent<Text>();
            _eventDidDraw.SetActive(false);
        }
        else
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(OnEventActivate());
        }
    }

    public IEnumerator OnEventActivate()
    {
        _eventDid++;
        _eventDidDraw.SetActive(true);
        _eventDidDrawText.text = ("You found " + _eventDid +" events out of 20");
        yield return new WaitForSeconds(3f);
        _eventDidDraw.SetActive(false);
        yield return 0;
    }
    
}
