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

            if (collision.gameObject.tag != "StartField")
            {
                Debug.Log("Player is not on field");
                onField = false;
            }

            if (onField == false) //Eisstock wird wieder zur?ckgelegt
            {
                Debug.Log("YOU ARE NOT ON THE FIELD!");
                eisstock.transform.position = new Vector3(-2,-1,-6); //noch falsche Position!

            }

        }

    }
  

