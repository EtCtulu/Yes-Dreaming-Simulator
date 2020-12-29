using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEventBird : MonoBehaviour
{
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!=null && other.tag == "Player")
        {
            bird.SetActive(true);
        }
    }
}
