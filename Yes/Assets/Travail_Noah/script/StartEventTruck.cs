using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEventTruck : MonoBehaviour
{
    public GameObject truck;
    public AudioSource fun;
    public bool end = false;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (end)
        {
            timer += Time.deltaTime;
            if (timer >= 4)
            {
                GameManager._instance.Coroutine();
                this.gameObject.SetActive(false);
                Destroy(truck);
                Destroy(this.gameObject);
            }
                
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!=null && other.tag == "Player")
        {
            fun.Play();
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            truck.SetActive(true);
            end = true;
        }
    }
}
