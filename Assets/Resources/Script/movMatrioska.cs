using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movMatrioska : MonoBehaviour
{
    public float tiempo = 2.0f;
    public float totalTime = 0;
    float detectarRuina;
    float detectarMatrioskaAliada;
    bool Build;
    // Use this for initialization
    void Start()
    {
        detectarRuina = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarRuina;
        detectarMatrioskaAliada = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliada;
        Build = false;
    }

    void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;
        totalTime = totalTime + 1 * Time.deltaTime;
        if (totalTime <= 60)
        {
            if (tiempo >= 2.0f)
            {
                MoveToRuin();
            }

            if (tiempo <= 0)
            {
                tiempo = 3.0f;
            }
        }
        else
        {
            MoveToMatrio();

        }
    }

    void MoveToMatrio()
    {
        Vector3 f = new Vector3();
        if (this.CompareTag("MatrioshkaRed"))
        {
            f = (GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
            if (this.transform.position.x >= f.x)
            {
                if (this.transform.position.y >= f.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
                }
            }
        }
        else
        {
            f = (GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
            if (this.transform.position.x >= f.x)
            {
                if (this.transform.position.y >= f.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
                }
            }
        }
    }

    void MoveToRuin()
    {
        Vector3 f = new Vector3();
        f = (GameObject.FindGameObjectWithTag("Ruin").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
        if (this.transform.position.x >= f.x || this.transform.position.y >= f.y)
        {
            {
                transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("Ruin").transform.position, 0.1f);
            }
        }
    }
}
