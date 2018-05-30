using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movBabuska : MonoBehaviour {
    public float tiempo = 2.0f;
    float detectarEnemigo;
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
            BlueResearchBabuska();
        }
        else
        {
            RedResearchBabuska();
        }

    }

    //Detectar objetivos Blue
    public void BlueResearchBabuska()
    {
        try
        {
            if (this.transform.position.x >= GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x)
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y)
                {

                    if ((this.transform.position.x - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x) <= detectarEnemigo &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleBlueBabuska();
                    }
                }
                else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x) <= detectarEnemigo &&
                   (GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlueBabuska();
                }
            }
            else if (this.transform.position.x < GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x)
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y)
                {
                    if ((GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleBlueBabuska();
                    }
                }
                else if ((GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                  (GameObject.FindGameObjectWithTag("RED_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlueBabuska();
                }
            }
            else
            {
                BlueResearchTrovo();
            }
        }
        catch
        {
            BlueResearchTrovo();
        }

    }

    public void BlueResearchTrovo()
    {
        try
        {
            if (this.transform.position.x >= GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.x)
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.y)
                {

                    if ((this.transform.position.x - GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.x) <= detectarEnemigo &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleBlueTrovo();
                    }
                }
                else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.x) <= detectarEnemigo &&
                   (GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlueTrovo();
                }
            }
            else if (this.transform.position.x < GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.x)
            {
                if (this.transform.position.y >= GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.y)
                {
                    if ((GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                    (this.transform.position.y - GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.y) <= detectarEnemigo)
                    {
                        GoBattleBlueTrovo();
                    }
                }
                else if ((GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                  (GameObject.FindGameObjectWithTag("RED_Trovo").transform.position.y - this.transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlueTrovo();
                }
            }
            else
            {
                BlueResearchMatrio();
            }
        }
        catch
        {
            BlueResearchMatrio();
        }
        
    }

    public void BlueResearchMatrio()
    {
        if (this.transform.position.x >= GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlueMatrio();
                }
            }
            else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x) <= detectarEnemigo &&
               (GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleBlueMatrio();
            }
        }
        else if (this.transform.position.x < GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y)
            {
                if ((GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleBlueMatrio();
                }
            }
            else if ((GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
              (GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleBlueMatrio();
            }
        }
        else
        {
            GoWhitBlueMatrioshka();
        }
    }

    //Movimiento Blue
    public void GoWhitBlueMatrioshka()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                 GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
    }

    public void GoBattleBlueBabuska()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("RED_Babuska").transform.position, 0.1f);
    }

    public void GoBattleBlueTrovo()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("RED_Trovo").transform.position, 0.1f);
    }

    public void GoBattleBlueMatrio()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
    }

    //Detectar objetivos Red
    public void RedResearchBabuska()
    {
        if (this.transform.position.x >= GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRedBabuska();
                }
            }
            else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x) <= detectarEnemigo &&
               (GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleRedBabuska();
            }
        }
        else if (this.transform.position.x < GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y)
            {
                if ((GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRedBabuska();
                }
            }
            else if ((GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
              (GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleRedBabuska();
            }
        }
        else
        {
            RedResearchTrovo();
        }
    }

    public void RedResearchTrovo()
    {
        if (this.transform.position.x >= GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRedTrovo();
                }
            }
            else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.x) <= detectarEnemigo &&
               (GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleRedTrovo();
            }
        }
        else if (this.transform.position.x < GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.y)
            {
                if ((GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRedTrovo();
                }
            }
            else if ((GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
              (GameObject.FindGameObjectWithTag("BLUE_Trovo").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleRedTrovo();
            }
        }
        else
        {
            RedResearchMatrio();
        }
    }

    public void RedResearchMatrio()
    {
        if (this.transform.position.x >= GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRedMatrio();
                }
            }
            else if ((this.transform.position.x - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x) <= detectarEnemigo &&
               (GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleRedMatrio();
            }
        }
        else if (this.transform.position.x < GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y)
            {
                if ((GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
                (this.transform.position.y - GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y) <= detectarEnemigo)
                {
                    GoBattleRedMatrio();
                }
            }
            else if ((GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.x - this.transform.position.x) <= detectarEnemigo &&
              (GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position.y - this.transform.position.y) <= detectarEnemigo)
            {
                GoBattleRedMatrio();
            }
        }
        else
        {
            GoWhitBlueMatrioshka();
        }
    }

    //Movimiento Red
    public void GoWhitRedMatrioshka()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
    }
    public void GoBattleRedBabuska()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("BLUE_Babuska").transform.position, 0.1f);
    }

    public void GoBattleRedTrovo()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("BLUE_trovo").transform.position, 0.1f);
    }

    public void GoBattleRedMatrio()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
    }
}
