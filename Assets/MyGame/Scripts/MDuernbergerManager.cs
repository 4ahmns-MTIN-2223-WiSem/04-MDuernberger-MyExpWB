using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MDuernbergerManager : MonoBehaviour
{
    public float pushForce = 10f;
    public Rigidbody rigidB;
    public GameObject daube;
    public GameObject eisstock;
    public TMP_Text distanceText;
    public TMP_Text pointsText;
    public GameObject player;
    public TMP_Text welcomeText;

    private bool wasMoving;
    public bool started = false;
    private float actualDistance;
    private float startDistance;
    private double shortNumberPoints;


    IEnumerator Start()
    {
        
        startDistance = Vector3.Distance(daube.transform.position, eisstock.transform.position);
        int i = 3;
        while(i > 0)
        {
            welcomeText.text = "Spiel startet in " + i;
            --i;
            yield return new WaitForSeconds(1);
        }
        welcomeText.text = "";
        started = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            Debug.Log(started);
            if (Input.GetKey(KeyCode.UpArrow) == true)
            {
                rigidB.AddForce(this.transform.forward * pushForce * Time.deltaTime, ForceMode.VelocityChange);
                wasMoving = true;
            }

           

            actualDistance = Vector3.Distance(daube.transform.position, eisstock.transform.position);

            // Debug.Log(actualDistance);
            double correctDistance = actualDistance - 0.5;

            double shortNumberDistance = Math.Round(correctDistance, 2);
            distanceText.text = "Distanz: " + shortNumberDistance.ToString();

            //points:
            double negativePoints = (correctDistance / startDistance) * 100;
            double positivePoints = 100 - negativePoints;

            shortNumberPoints = Math.Round(positivePoints, 0);
            pointsText.text = "Punkte: " + shortNumberPoints;

        }

    }

    
}
