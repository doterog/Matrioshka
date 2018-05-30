using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBlue : MonoBehaviour {

    public GameObject Blue_babuska;
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
        text.text = "total blue: " + GameObject.FindGameObjectsWithTag("BLUE_Babuska").Length + " / " + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().maxBabuskaBlue;
        if (GameObject.FindGameObjectsWithTag("BLUE_Babuska").Length != GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().maxBabuskaBlue)
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
        GameObject Redbabuska = Instantiate(Blue_babuska, transform.position, transform.rotation) as GameObject;
        Redbabuska.name = "Blue_" + GameObject.FindGameObjectsWithTag("BLUE_Babuska").Length;

        tiempo = tiempospawn;
    }
}
