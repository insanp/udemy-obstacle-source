using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 3.0f;

    private Rigidbody myRB;
    private MeshRenderer myMR;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        myMR = GetComponent<MeshRenderer>();
        myRB.useGravity = false;
        myMR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToDrop)
        {
            myRB.useGravity = true;
            myMR.enabled = true;
        }
    }
}
