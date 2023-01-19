using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MelanieManager : MonoBehaviour
{
    public float pushForce = 10f;
    public Rigidbody rigidB;
    public GameObject daube;
    public GameObject eisstock;
    public TMP_Text distanceText;
    public TMP_Text pointsText;
    public GameObject player;

    private bool wasMoving;
    private float actualDistance;
    private float startDistance;

    
    void Start()
    {
        startDistance = Vector3.Distance(daube.transform.position, eisstock.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
           rigidB.AddForce(this.transform.forward * pushForce * Time.deltaTime, ForceMode.VelocityChange);
          wasMoving = true;
        }
       

        
            actualDistance = Vector3.Distance(daube.transform.position, eisstock.transform.position);

            // Debug.Log(actualDistance);
            double correctDistance = actualDistance - 0.5;
  
            double shortNumberDistance = Math.Round(correctDistance,2);
            distanceText.text = "Distanz: " + shortNumberDistance.ToString();
            

   
            //points:
           double negativePoints  = (correctDistance/startDistance)*100;
            double positivePoints = 100 - negativePoints;
           
            double shortNumberPoints = Math.Round(positivePoints, 0);
            pointsText.text = "Punkte: " + shortNumberPoints;
        



    }

 
}
