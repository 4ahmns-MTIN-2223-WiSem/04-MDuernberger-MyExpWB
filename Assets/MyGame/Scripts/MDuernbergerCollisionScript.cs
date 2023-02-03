using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MDuernbergerCollisionScript : MonoBehaviour
{
    public GameObject daube;
    public GameObject eisstock;
    public Rigidbody rb;
    public AudioSource audioPlayer;

   

    

    private bool isonFloor = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "daube")
        {
            Debug.Log("Boom");
            audioPlayer.Play();

        }
        
    }

    

    // Update is called once per frame
    void Update()
    {
       
        

    }


}
