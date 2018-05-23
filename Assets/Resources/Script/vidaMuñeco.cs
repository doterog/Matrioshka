using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaMuñeco : MonoBehaviour {
    public int vida = 60;
    public Rigidbody2D rigid;
    void Update()
    {
        this.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        enableRigidBody();

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

    void enableRigidBody()
    {
        if (rigid.isKinematic)
        {
            rigid.isKinematic = false;
            rigid.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
            this.transform.position = -Vector3.MoveTowards(transform.position,
                    GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position, 0.1f);
        }
        else
        {
            rigid.isKinematic = true;
            rigid.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        }
    }
}
