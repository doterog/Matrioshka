using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    public GameObject Red_babuska, Blue_babuska;
    public int totalBabuska = 1;
    public int maxBabuska = 10;
    public float tiempospawn = 5.0f;
    public float tiempo = 5f;

    // Use this for initialization
    void Start () {
        tiempo = tiempospawn;

    }
	
	// Update is called once per frame
	void Update () {
        if (totalBabuska != maxBabuska)
        {

            tiempo = tiempo - 1 * Time.deltaTime;

            if (tiempo <= 0.0f)
            {
                Spawn();
            }

        }
        
        }
    void Spawn()
    {
        if (this.tag.Equals("MatrioshkaRed"))
        {
            GameObject Redbabuska = Instantiate(Red_babuska, transform.position, transform.rotation) as GameObject;
            Redbabuska.name = "Red_" + totalBabuska;
        }
        else
        {
            GameObject Redbabuska = Instantiate(Blue_babuska, transform.position, transform.rotation) as GameObject;
            Redbabuska.name = "Blue_" + totalBabuska;
        }
        totalBabuska++;
        tiempo = tiempospawn;
    }
}
