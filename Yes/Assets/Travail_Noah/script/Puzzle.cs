using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject target;
    public bool end=false;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (end)
        {
            Destroy(this.GetComponent<Rigidbody>());
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!=null && other.tag == $"Target{id}")
        {
            this.gameObject.transform.position = target.transform.position;
            this.gameObject.transform.rotation = target.transform.rotation;

            end = true;
        }
    }
}
