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
        if (index==4)
        {
                Debug.Log("event added");
            Destroy(this.gameObject);
        }
        this.transform.position = positions[index].transform.position;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        index += 1;
    }
}
