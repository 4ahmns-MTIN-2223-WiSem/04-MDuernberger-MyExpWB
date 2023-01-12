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
            }


            if (onField == false) //Eisstock wird wieder zurückgelegt, soll nicht auswählbar sein, Message: Step on the Field!
            {
                Debug.Log("YOU ARE NOT ON THE FIELD!");
                eisstock.transform.position = new Vector3(-2,-1,-6); //noch falsche Position!

            }

        }

    }
  

