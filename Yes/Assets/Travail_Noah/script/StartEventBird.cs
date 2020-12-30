using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEventBird : MonoBehaviour
{
    public GameObject bird;
    public bool end=false;
    public float timer=0f;
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
            if (timer >= 5)
            {
                Destroy(bird);
                Destroy(this.gameObject);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!=null && other.tag == "Player")
        {
            end = true;
            bird.SetActive(true);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            GameManager._instance.Coroutine();
        }
    }
}
