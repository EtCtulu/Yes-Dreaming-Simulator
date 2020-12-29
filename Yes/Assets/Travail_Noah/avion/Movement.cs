using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 axis = new Vector3();
    public float freq = 0;
    public float speed = 0;

    public bool move = true;

    private Vector3 origin;

    void Start()
    {
        
    }

    void Update()
    {   origin = transform.position;
        if (move)
        {
            float sin = Mathf.Sin(Time.time * speed);
            transform.position = origin + axis * sin * freq;
        }
    }
}
