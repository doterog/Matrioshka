using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movTrovo : MonoBehaviour {

    public float tiempo = 2.0f;
    float detectarRuina;
    float detectarMatrioskaAliada;
    public UnityEngine.UI.Text text;
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

        if (tiempo >= 2.0f)
        {
            Move();
        }

        if (tiempo <= 0)
        {
            tiempo = 3.0f;
        }
    }
    void Move()
    {
        if (this.transform.position.x >= GameObject.FindGameObjectWithTag("Ruin").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("Ruin").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.FindGameObjectWithTag("Ruin").transform.position.x) <= detectarRuina &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("Ruin").transform.position.y) <= detectarRuina)
                {
                    Build =true;
                }
            }
            else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("Ruin").transform.position.x) <= detectarRuina &&
               (GameObject.FindGameObjectWithTag("Ruin").transform.position.y - this.transform.position.y) <= detectarRuina)
            {
                Build = true;
            }
        }
        else
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("Ruin").transform.position.y)
            {
                if ((GameObject.FindGameObjectWithTag("Ruin").transform.position.x - this.transform.position.x) <= detectarRuina &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("Ruin").transform.position.y) <= detectarRuina)
                {
                    Build = true;
                }
            }
            else if ((GameObject.FindGameObjectWithTag("Ruin").transform.position.x - this.transform.position.x) <= detectarRuina &&
              (GameObject.FindGameObjectWithTag("Ruin").transform.position.y - this.transform.position.y) <= detectarRuina)
            {
                Build = true;
            }
        }
        if (Build)
        {
            GoBuild();
        }
        else
        {
            
            GoWhitMatrioshka();
            Build = false;
        }
    }

    void GoWhitMatrioshka()
    {
        if (this.CompareTag("BLUE_Trovo"))
        {
            if (this.transform.position.x >= GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x)
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y)
                {
                    if ((this.transform.position.x - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x) >= detectarMatrioskaAliada &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y) >= detectarMatrioskaAliada)
                    {
                        transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
                    }
                }
                else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x) >= detectarMatrioskaAliada &&
                   (GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y - this.transform.position.y) >= detectarMatrioskaAliada)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
                }
            }
            else
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y)
                {
                    if ((GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x - this.transform.position.x) >= detectarMatrioskaAliada &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y) >= detectarMatrioskaAliada)
                    {
                        transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
                    }
                }
                else if ((GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x - this.transform.position.x) >= detectarMatrioskaAliada &&
                  (GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y - this.transform.position.y) >= detectarMatrioskaAliada)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
                }
            }
            text.text = "D-x: " + System.Math.Round(this.transform.position.x - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x, 2) + "/D-y: " + System.Math.Round(this.transform.position.y - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y, 2);

        }
        else
        {
            if (this.transform.position.x >= GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x)
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y)
                {
                    if ((this.transform.position.x - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x) >= detectarMatrioskaAliada &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y) >= detectarMatrioskaAliada)
                    {
                        transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
                    }
                }
                else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x) >= detectarMatrioskaAliada &&
                   (GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y - this.transform.position.y) >= detectarMatrioskaAliada)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
                }
            }
            else
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y)
                {
                    if ((GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x - this.transform.position.x) >= detectarMatrioskaAliada &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y) >= detectarMatrioskaAliada)
                    {
                        transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
                    }
                }
                else if ((GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x - this.transform.position.x) >= detectarMatrioskaAliada &&
                  (GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y - this.transform.position.y) >= detectarMatrioskaAliada)
                {
                    transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
                }
            }
            text.text = "D-x: " + System.Math.Round(this.transform.position.x - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x, 2) + "/D-y: " + System.Math.Round(this.transform.position.y - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y, 2);
        }

    }

    void GoBuild()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("Ruin").transform.position, 0.1f);
    }
}
