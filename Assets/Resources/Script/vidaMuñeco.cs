using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaMuñeco : MonoBehaviour {
    public int vida = 1;
    void Update()
    {
        if (this.transform.position.y <= -100)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (this.tag.Equals("BLUE_Babuska"))
        {
            if (GameObject.FindGameObjectWithTag("RED_Babuska"))
            {
                vida--;
                if (vida == 0)
                {
                    Destroy(this.gameObject);
                    Destroy(collision.gameObject);
                }
            }
        }
        else
        {
            if (GameObject.FindGameObjectWithTag("BLUE_Babuska"))
            {
                vida--;
                if (vida == 0)
                {
                    Destroy(this.gameObject);
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}
