using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movMatrioska : MonoBehaviour
{
    public float tiempo = 2.0f;
    public float totalTime = 0;
    float detectRuin;
    float detectarMatrioskaAliada;
    bool Build;
    Vector3 detectRuinV3 = new Vector3();
    // Use this for initialization
    void Start()
    {
        detectRuin = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarRuina;
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
        
        if (this.CompareTag("MatrioshkaRed"))
        {
            GoToRuin3();
        }
        else
        {
            GoToRuin4();
        }
        
        
    }

    void GoToRuin4()
    {

        if (this.CompareTag("MatrioshkaRed"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[3])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_4").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_4").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin3();
            }
        }
        

        if (this.CompareTag("Matrioshkablue"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[3])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_4").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_4").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin2();
            }
        }

    }

    void GoToRuin3()
    {
        if (this.CompareTag("MatrioshkaRed"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[2])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_3").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_3").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin1();
            }
        }


        if (this.CompareTag("Matrioshkablue"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[2])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_3").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_3").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin4();
            }
        }
    }

    void GoToRuin2()
    {
        if (this.CompareTag("MatrioshkaRed"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[1])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_2").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_2").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin4();
            }
        }


        if (this.CompareTag("Matrioshkablue"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[1])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_2").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_2").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin1();
            }
        }
    }

    void GoToRuin1()
    {
        if (this.CompareTag("MatrioshkaRed"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[0])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_1").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_1").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin2();
            }
        }


        if (this.CompareTag("Matrioshkablue"))
        {
            if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[0])
            {
                detectRuinV3 = (GameObject.Find("E_RUINS_1").transform.position + GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliadaV3);
                if (this.transform.position.x >= detectRuinV3.x || this.transform.position.y >= detectRuinV3.y)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                    GameObject.Find("E_RUINS_1").transform.position, 0.1f);
                }
            }
            else
            {
                GoToRuin3();
            }
        }
    }
}
