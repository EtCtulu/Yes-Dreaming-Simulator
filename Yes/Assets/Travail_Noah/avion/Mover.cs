using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Mover : MonoBehaviour
{
    public Vector3 dir = Vector3.right;

    public float speed = 1.0f;

    public bool grounded = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!grounded)
        {
            
            transform.position +=  dir*speed*Time.deltaTime;
            if (this.gameObject.GetComponent<Movement>() != null)
            {
                this.gameObject.GetComponent<Movement>().move = false;
            }
        }
        else 
            this.gameObject.GetComponent<Rigidbody>().useGravity=true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ll");
        grounded = true;
    }
}
