using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public GameObject sphere;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);

        sphere.transform.position = Vector3.zero;
        sphere.GetComponent<Rigidbody>().useGravity = false;
        sphere.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
