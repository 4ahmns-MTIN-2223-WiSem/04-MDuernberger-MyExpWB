using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject daube;
    public GameObject eisstock;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "daube")
        {
            Debug.Log("Boom");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
