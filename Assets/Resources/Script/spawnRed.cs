using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRed : MonoBehaviour {

    public GameObject Red_babuska;
    public int totalBabuskaActual;
    public int maxBabuska;
    public float tiempospawn = 5.0f;
    public float tiempo = 5f;
    public UnityEngine.UI.Text text;

    // Use this for initialization
    void Start()
    {
        maxBabuska = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().maxBabuska;
        totalBabuskaActual = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().totalBabuska;
        tiempo = tiempospawn;

    }

    // Update is called once per frame
    void Update()
    {
        totalBabuskaActual = GameObject.FindGameObjectsWithTag("RED_Babuska").Length;
        text.text = "total red: " + totalBabuskaActual + " / " + maxBabuska;
        
        if (totalBabuskaActual != maxBabuska)
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
        Redbabuska.name = "Red_" + totalBabuskaActual;
        tiempo = tiempospawn;
    }
}
