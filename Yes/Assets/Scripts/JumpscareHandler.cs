using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareHandler : MonoBehaviour
{
    public GameObject jumpScare;
    public GameObject player;
    public GameObject music;
    public GameObject camera;
    void Start()
    {
        StartCoroutine(Jumpscare());
    }

    

    public IEnumerator Jumpscare()
    {
        yield return new WaitForSeconds(15);
        /*Destroy(player);
        camera.SetActive(true);
        Destroy(music);
        jumpScare.SetActive(true);*/
        yield return new WaitForSeconds(0.2f);
        Application.Quit();
        
    }
    
}
