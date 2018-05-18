using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float tiempo = 2.0f;
    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {

        tiempo = tiempo - 1 * Time.deltaTime;

        if (tiempo >= 2.0f)
        {
            movimiento();
        }

        if (tiempo <= 0)
        {
            tiempo = 3.0f;
        }

    }

    public void movimiento()
    {
        if (this.tag.Equals("BLUE_Babuska"))
        {
            if (GameObject.FindGameObjectWithTag("RED_Babuska"))
            {
                transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("RED_Babuska").transform.position, 0.1f);

            }else if (GameObject.FindGameObjectWithTag("RED_Trovo"))
            {
                transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("RED_Trovo").transform.position, 0.1f);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);

            }
        }
        else
        {
            if (GameObject.FindGameObjectWithTag("BLUE_Babuska"))
            {
                transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position, 0.1f);

            }
            else if (GameObject.FindGameObjectWithTag("BLUE_trovo"))
            {
                transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("BLUE_trovo").transform.position, 0.1f);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);

            }


        }
    }
}
