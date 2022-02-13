using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bumped into wall");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
