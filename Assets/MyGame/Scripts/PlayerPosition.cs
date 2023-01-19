using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private bool onField;
    public GameObject eisstock;
     
        
        private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "StartField")
        {
            Debug.Log("Player is on Field");
            onField = true;
            //eisstock.GetComponent<Collider>().enabled = true;
        }


       else //Eisstock wird wieder zurückgelegt, soll nicht auswählbar sein, Message: Step on the Field!
            {
                Debug.Log("YOU ARE NOT ON THE FIELD!");
            // eisstock.GetComponent<Collider>().enabled = false;
            eisstock.transform.position = new Vector3(Convert.ToSingle(-0.79), Convert.ToSingle(-1.91), Convert.ToSingle(-6.78));

        }

        }

    }
  

