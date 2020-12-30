using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingItem : MonoBehaviour
{
    public int index = 0;
    public List<GameObject> positions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (index==positions.Count)
        {
           
            Debug.Log("event added");
            Destroy(this.gameObject);
            GameManager._instance.Coroutine();
        }
        this.transform.position = positions[index].transform.position;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag!=null && collision.gameObject.tag=="Player")
        index += 1;
    }
}
