﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


/*public class PlayerController : MonoBehaviour
{
    float speed = 4;
    float rotSpeed = 80;
    float gravity = 8;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator anim;

    void Start()
    {
        controller = GetComponent<CharacterController>(); anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.Setlnteger("condition", 1);
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.Setlnteger("condition", 0);| moveDir = new Vector3(0, 0, 0);
            }
        }
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime
        transform.eulerAngles = new Vector3(0, rot, 0);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}*/
