using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public List<GameObject> Blocks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Blocks[0].GetComponent<Puzzle>().end && Blocks[1].GetComponent<Puzzle>().end && Blocks[2].GetComponent<Puzzle>().end)
        {
            Debug.Log("event added");
        }
    }
}
