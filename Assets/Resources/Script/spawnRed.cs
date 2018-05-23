using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRed : MonoBehaviour {

    public GameObject Red_babuska;
    public int totalBabuska = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().totalBabuska;
    public int maxBabuska = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().maxBabuska;
    public float tiempospawn = 5.0f;
    public float tiempo = 5f;

    // Use this for initialization
    void Start()
    {
        tiempo = tiempospawn;

    }

    // Update is called once per frame
    void Update()
    {
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

        GameObject Redbabuska = Instantiate(Red_babuska, transform.position, transform.rotation) as GameObject;
        Redbabuska.name = "Red_" + totalBabuska;

        totalBabuska++;
        tiempo = tiempospawn;
    }
}
