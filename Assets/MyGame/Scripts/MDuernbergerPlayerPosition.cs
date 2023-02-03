using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MDuernbergerPlayerPosition : MonoBehaviour
{
    private bool onField;
    public GameObject eisstock;
    public GameObject position;
    public TMP_Text warningText;
    public AudioSource audioPlayer;
    private bool isPlaying;

    
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "StartField")
        {
            isPlaying = false;
            audioPlayer.Stop();
            

            Debug.Log("Player is on Field");
            onField = true;
            //eisstock.GetComponent<Collider>().enabled = true;
            warningText.text = "";
        }


       else if (collision.gameObject.tag == "Floor") //Eisstock wird wieder zurückgelegt, soll nicht auswählbar sein, Message: Step on the Field!
            {
            
            audioPlayer.Play();
            isPlaying = true;

            Debug.Log("YOU ARE NOT ON THE FIELD!");
            eisstock.transform.position = position.transform.position;
            warningText.text = "Step on the wooden floor.";

        
        }


        else
        {
            isPlaying = false;
            warningText.text = "";
            audioPlayer.Stop();
        }

      

    }

    }
  

