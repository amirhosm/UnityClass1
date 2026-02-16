using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.tag);
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.tag);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.tag);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.contacts[0].point);
    }


    private void FixedUpdate()
    {
        //Debug.Log(rb.velocity);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("GetKeyUp");
        }
    }

}
