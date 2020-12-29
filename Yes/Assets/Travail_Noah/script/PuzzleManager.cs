using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public List<GameObject> Blocks;
    public bool end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Blocks[2] == null)
        {
            if (!end &&Blocks[0].GetComponent<Puzzle>().end && Blocks[1].GetComponent<Puzzle>().end)
            {
                //compte un point
                Debug.Log("event over");
                end = true;
            }
        }
        else
        {
            if (!end &&Blocks[0].GetComponent<Puzzle>().end && Blocks[1].GetComponent<Puzzle>().end && Blocks[2].GetComponent<Puzzle>().end)
            {
                //coroutine
                end = true;
                Debug.Log("event added");
            }
        }
        
    }
}
