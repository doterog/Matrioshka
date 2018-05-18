using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float tiempo = 2.0f;
    public float vel = 5;
    public float posInicial = 0;
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

        if (GameObject.FindGameObjectWithTag("Enemigo"))
        {
            transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("Enemigo").transform.position, 0.1f);

        }
        
    }
}
