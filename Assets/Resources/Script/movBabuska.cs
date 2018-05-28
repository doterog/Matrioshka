using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBabuska : MonoBehaviour {
    public float tiempo = 2.0f;
    float detectarEnemigo;
    public UnityEngine.UI.Text text;
    // Use this for initialization
    void Start()
    {
        detectarEnemigo = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarEnemigo;
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

    public void Move()
    {
        //Comprobación en caso de que el babuska se encuentre a cierto rango del enemigo
        if (this.tag.Equals("BLUE_Babuska"))
        {
            if(this.transform.position.x>= GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x)
            {
                if(this.transform.position.y >= GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y)
                {
                    
                    if ((this.transform.position.x - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x) <= detectarEnemigo ||
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleBlue();
                    }
                }
                else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x) <= detectarEnemigo ||
                   (GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlue();
                }
            }
            else
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y)
                {
                    if ((GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo ||
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleBlue();
                    }
                }
                else if ((GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo ||
                  (GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlue();
                }
            }
            //text.text = "Dist-x: " + System.Math.Round(this.transform.position.x - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x,2)+ "/Dist-y: " + System.Math.Round(this.transform.position.y - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y, 2);
            
        }



        else
        {
            if (this.transform.position.x >= GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x)
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y)
                {

                    if ((this.transform.position.x - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x) <= detectarEnemigo ||
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleRed();
                    }
                }
                else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x) <= detectarEnemigo ||
                   (GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRed();
                }
            }
            else
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y)
                {
                    if ((GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo ||
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleRed();
                    }
                }
                else if ((GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo ||
                  (GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRed();
                }
            }
            //text.text = "Dist-x: " + System.Math.Round(this.transform.position.x - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x, 2) + "/Dist-y: " + System.Math.Round(this.transform.position.y - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y, 2);

        }

    }

    public void GoBattleBlue()
    {
        if (GameObject.FindGameObjectWithTag("RED_Babuska"))
        {
            transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("RED_Babuska").transform.position, 0.1f);
        }
        else if (GameObject.FindGameObjectWithTag("RED_Trovo"))
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

    public void GoBattleRed()
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
