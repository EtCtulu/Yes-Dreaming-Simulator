using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 axis = new Vector3();
    public float freq = 0;
    public float speed = 0;

    public bool move = true;

    private Vector3 origin;

    void Start()
    {
        origin = transform.position;
    }

    void Update()
    {
        if (move)
        {
            float sin = Mathf.Sin(Time.time * speed);
            transform.localRotation = Quaternion.AngleAxis(sin * freq * Mathf.Rad2Deg, axis);
        }
    }
}
