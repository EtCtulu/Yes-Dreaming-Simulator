using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingItem : MonoBehaviour
{
    public List<AudioSource> animalsound;
    public int index = 0;
    public List<GameObject> positions;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (index == positions.Count)
        {

            Debug.Log("event added");
            GameManager._instance.Coroutine();
            Destroy(this.gameObject);
            
        }
        this.transform.position = positions[index].transform.position;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != null && collision.gameObject.tag == "Player" && index == positions.Count - 1)
        {
            index += 1;
            animalsound[0].Play();
            //joue son2
        }
        else if (collision.gameObject.tag != null && collision.gameObject.tag == "Player"&& index<positions.Count-1)
        {
            index += 1;
            animalsound[1].Play();
            //joue son1
        }
    }
}
