using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MDuernbergerDragWithMouse : MonoBehaviour
{
    private Vector3 mouseOffset;
    private float mouseZCoordinate;
    private bool started = false;

    public float pushForce = 10f;
    public Rigidbody rigidB;

    private IEnumerator Start()
    {
        for(int i = 3; i > 0; --i)
        {
            yield return new WaitForSeconds(1);
            
        }
        started = true;
    }

    private void OnMouseDown()
    {
        if (started)
        {
            mouseZCoordinate = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            mouseOffset = gameObject.transform.position - GetMouseWorldPos();
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseZCoordinate;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        if (started)
        { transform.position = GetMouseWorldPos() + mouseOffset; }
    }





    public float throwForce = 10f;
   
    private bool isHolding = false;

    private void Update()
    {

        if (!started)
            return;

        if (Input.GetMouseButtonDown(0))
        {
           
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f))
            {
            
                if (rigidB != null)
                {
                    isHolding = true;
                }


            }
        }

        if (Input.GetMouseButtonUp(0) && isHolding)
        {
            isHolding = false;
            rigidB.AddForce(Camera.main.transform.forward * throwForce, ForceMode.Impulse);
        }

        
    }

}
