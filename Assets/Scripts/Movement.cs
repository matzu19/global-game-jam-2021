﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    public float speed;
    public float rotationAnglePerSecond;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0.0f, verticalInput);
        rigid.AddForce(movementDirection * speed);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationAnglePerSecond * Time.deltaTime);
        }
    }
}
