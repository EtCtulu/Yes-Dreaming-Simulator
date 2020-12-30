using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public static GameManager _instance;

    private int _eventDid = 0;
    private GameObject _eventDidDraw;
    private Text _eventDidDrawText;
    private GameObject _endTrigger;
    
    void Start()
    {
        
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
            _eventDidDraw = GameObject.FindGameObjectWithTag("TextEvent");
            _eventDidDrawText = _eventDidDraw.GetComponent<Text>();
            _eventDidDraw.SetActive(false);
            _endTrigger = GameObject.FindGameObjectWithTag("EndTrigger");
            _endTrigger.SetActive(false);
        }
        else
        {
            Destroy(this);
        }
    }



    private IEnumerator OnEventActivate()
    {
        _eventDid++;
        _eventDidDraw.SetActive(true);
        if (_eventDid < 15)
        {
            _eventDidDrawText.text = ("You found " + _eventDid + " events out of 16");
        }
        if (_eventDid == 16)
        {
            _eventDidDrawText.text = ("You found all the events, return to the center");
        }

        if (_eventDid <= 16)
        {
            if (_eventDid == 16)
            {
                _endTrigger.SetActive(true);
            }
            yield return new WaitForSeconds(3f);
            _eventDidDraw.SetActive(false);
            yield return 0;
            
        }
    }
    
    


    public void Coroutine()
    {
        StartCoroutine(OnEventActivate());
    }
    
}
