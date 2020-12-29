using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Mover : MonoBehaviour
{
    public Vector3 dir = Vector3.right;

    public float speed = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir*speed*Time.deltaTime;
    }
}
