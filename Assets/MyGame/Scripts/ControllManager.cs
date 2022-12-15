using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllManager : MonoBehaviour
{
    public float pushForce = 10f;
    public Rigidbody rigidB;
    public GameObject daube;
    public GameObject eisstock;
    public TMP_Text distanceText;
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
       

        if (wasMoving && transform.hasChanged)
        {
            actualDistance = Vector3.Distance(daube.transform.position, eisstock.transform.position);
            //Debug.Log(actualDistance);

            distanceText.text = "Distanz: " + actualDistance.ToString();

            //calculate points
            float points = startDistance - actualDistance;
            //Debug.Log(points);
        }

     

        //Wenn aktuelle Geschwindigkeit = 0 --> Punkteanzeige

        //if (wasMoving && !transform.hasChanged)
        //{
        //    float points = 10 - actualDistance;
        //    distanceText.text = "Punkte: " + points;

        //}
    }

 
}
