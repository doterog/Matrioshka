﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaMatrioska : MonoBehaviour {
    public int vida;
    public Rigidbody2D rigid;
    void Start()
    {
        vida = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().vidaMatrioska;
    }
    void Update()
    {
        this.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        enableRigidBody();

        if (this.gameObject.tag == "Matrioshkablue")
        {
            if (collision.gameObject.tag == "RED_Babuska")
            {
                vida--;
                if (vida == 0)
                {

                    Destroy(this.gameObject);
                    Destroy(collision.gameObject);
                }
                else
                {
                    enableRigidBody();
                }
            }
        }
        else
        {
            if (collision.gameObject.tag == "BLUE_Babuska")
            {
                vida--;
                if (vida == 0)
                {
                    Destroy(this.gameObject);
                    Destroy(collision.gameObject);
                }
                else
                {
                    enableRigidBody();
                }
            }

        }
    }

    void enableRigidBody()
    {
        if (rigid.isKinematic)
        {
            rigid.isKinematic = false;
            rigid.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
        }
        else
        {
            rigid.isKinematic = true;
            rigid.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        }
    }
}
