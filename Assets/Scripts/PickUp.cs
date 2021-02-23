using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;

    Rigidbody rb;

    void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        //GetComponent<Rigidbody>().useGravity = false;

        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;

        GetComponent<Orbit>().enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePosition;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        //GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;

        rb.constraints = RigidbodyConstraints.None;
    }
}
