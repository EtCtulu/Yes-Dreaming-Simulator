using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRest : MonoBehaviour
{
    public Vector3 min = new Vector3();
    public Vector3 max = new Vector3();

    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.z < min.z)
            pos.z = max.z;
        if (pos.z > max.z)
            pos.z = min.z;

        transform.position = pos;
    }
}
