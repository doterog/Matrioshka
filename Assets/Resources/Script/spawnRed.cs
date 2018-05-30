using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRed : MonoBehaviour {

    public GameObject Red_babuska;
    public float tiempospawn = 5.0f;
    public float tiempo = 5f;
    public UnityEngine.UI.Text text;

    // Use this for initialization
    void Start()
    {
        tiempo = tiempospawn;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "total red: " + GameObject.FindGameObjectsWithTag("RED_Babuska").Length + " / " + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().maxBabuskaRed;

        if (GameObject.FindGameObjectsWithTag("RED_Babuska").Length != GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().maxBabuskaRed)
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
        Redbabuska.name = "Red_" + GameObject.FindGameObjectsWithTag("RED_Babuska").Length;

        tiempo = tiempospawn;
    }
}
