using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Vector3 screenPoint;

    private void OnMouseDown()
    {
        Debug.Log(transform.position);
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log(screenPoint);
    }

    private void OnMouseUp()
    {
        //Debug.Log("OnMouseUp");
        GetComponent<Rigidbody>().AddForce(new Vector3(0,1,1) * 1000);
        GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnMouseDrag()
    {
        //Debug.Log("OnMouseDrag");
        //Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        //Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        //Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y, 0);
        //Debug.Log(newPosition);
        //transform.position = newPosition;
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("GetMouseButtonDown");
        //}

        //Debug.Log(Input.mousePosition);

        if (transform.position.y < -6)
        {
            Reset();
        }
    }

    private void Reset()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
