using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] float moveSpeed = 100f;
    [SerializeField] float jumpSpeed = 0.01f;

    Rigidbody myRB;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        InitializePosition();
        
    }

    private void InitializePosition()
    {
        transform.Translate(new Vector3(0f, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    private void MovePlayer()
    {
        float xVel = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float zVel = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        myRB.velocity = new Vector3(xVel, 0, zVel);
    }
}
