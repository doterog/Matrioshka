using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movTrovo : MonoBehaviour {

    public float time = 2.0f;
    public float totalTime = 0;
    float detectRuin;
    float detectMatrioskaAliad;
    bool Build;
    // Use this for initialization
    void Start()
    {
        detectRuin = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarRuina;
        detectMatrioskaAliad = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().detectarMatrioskaAliada;
        Build = false;
    }

    void Update()
    {
        time = time - 1 * Time.deltaTime;

        if (time >= 2.0f)
        {
            if (this.CompareTag("BLUE_Trovo"))
            {
                DetectRuinBlue1();
            }else
            {
                DetectRuinRed1();
            }
        }

        if (time <= 0)
        {
            time = 3.0f;
        }
    }

    void DetectRuinBlue1()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[0])
        {
            DetectRuin1();
        }
        else
        {
            DetectRuin2();
        }

    }
    void DetectRuinRed1()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[0])
        {
            DetectRuin1();
        }
        else
        {
            DetectRuin2();
        }

    }
    void DetectRuin1()
    {
        if (this.transform.position.x >= GameObject.Find("E_RUINS_1").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_1").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.Find("E_RUINS_1").transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_1").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((this.transform.position.x - GameObject.Find("E_RUINS_1").transform.position.x) <= detectRuin &&
               (GameObject.Find("E_RUINS_1").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        else
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_1").transform.position.y)
            {
                if ((GameObject.Find("E_RUINS_1").transform.position.x - this.transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_1").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((GameObject.Find("E_RUINS_1").transform.position.x - this.transform.position.x) <= detectRuin &&
              (GameObject.Find("E_RUINS_1").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        if (Build)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            GameObject.Find("E_RUINS_1").transform.position, 0.1f);
        }
        else
        {
            if (this.CompareTag("BLUE_Trovo"))
            {
                DetectRuinBlue2();
            }
            else
            {
                DetectRuinRed2();
            }
        }
        Build = false;
    }


    void DetectRuinBlue2()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[1])
        {
            DetectRuin2();
        }
        else
        {
            DetectRuin3();
        }

    }
    void DetectRuinRed2()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[1])
        {
            DetectRuin2();
        }
        else
        {
            DetectRuin3();
        }

    }
    void DetectRuin2()
    {
        if (this.transform.position.x >= GameObject.Find("E_RUINS_2").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_2").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.Find("E_RUINS_2").transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_2").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((this.transform.position.x - GameObject.Find("E_RUINS_2").transform.position.x) <= detectRuin &&
               (GameObject.Find("E_RUINS_2").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        else
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_2").transform.position.y)
            {
                if ((GameObject.Find("E_RUINS_2").transform.position.x - this.transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_2").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((GameObject.Find("E_RUINS_2").transform.position.x - this.transform.position.x) <= detectRuin &&
              (GameObject.Find("E_RUINS_2").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        if (Build)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            GameObject.Find("E_RUINS_2").transform.position, 0.1f);
        }
        else
        {
            if (this.CompareTag("BLUE_Trovo"))
            {
                DetectRuinBlue3();
            }
            else
            {
                DetectRuinRed3();
            }
        }
        Build = false;
    }
    void DetectRuinBlue3()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[2])
        {
            DetectRuin3();
        }

    }
    void DetectRuinRed3()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[2])
        {
            DetectRuin3();
        }

    }
    void DetectRuin3()
    {
        if (this.transform.position.x >= GameObject.Find("E_RUINS_3").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_3").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.Find("E_RUINS_3").transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_3").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((this.transform.position.x - GameObject.Find("E_RUINS_3").transform.position.x) <= detectRuin &&
               (GameObject.Find("E_RUINS_3").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        else
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_3").transform.position.y)
            {
                if ((GameObject.Find("E_RUINS_3").transform.position.x - this.transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_3").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((GameObject.Find("E_RUINS_3").transform.position.x - this.transform.position.x) <= detectRuin &&
              (GameObject.Find("E_RUINS_3").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        if (Build)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            GameObject.Find("E_RUINS_3").transform.position, 0.1f);
        }
        else
        {
            if (this.CompareTag("BLUE_Trovo"))
            {
                DetectRuinBlue4();
            }
            else
            {
                DetectRuinRed4();
            }
        }
        Build = false;
    }
    void DetectRuinBlue4()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinBlue[3])
        {
            DetectRuin4();
        }
        else
        {
            DetectRuin4();
        }

    }
    void DetectRuinRed4()
    {
        if (!GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().colorRuinRed[3])
        {
            DetectRuin4();
        }
        else
        {
            DetectRuin4();
        }

    }
    void DetectRuin4()
    {
        if (this.transform.position.x >= GameObject.Find("E_RUINS_4").transform.position.x)
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_4").transform.position.y)
            {

                if ((this.transform.position.x - GameObject.Find("E_RUINS_4").transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_4").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((this.transform.position.x - GameObject.Find("E_RUINS_4").transform.position.x) <= detectRuin &&
               (GameObject.Find("E_RUINS_4").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        else
        {
            if (this.transform.position.y >= GameObject.Find("E_RUINS_4").transform.position.y)
            {
                if ((GameObject.Find("E_RUINS_4").transform.position.x - this.transform.position.x) <= detectRuin &&
                (this.transform.position.y - GameObject.Find("E_RUINS_4").transform.position.y) <= detectRuin)
                {
                    Build = true;
                }
            }
            else if ((GameObject.Find("E_RUINS_4").transform.position.x - this.transform.position.x) <= detectRuin &&
              (GameObject.Find("E_RUINS_4").transform.position.y - this.transform.position.y) <= detectRuin)
            {
                Build = true;
            }
        }
        if (Build)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            GameObject.Find("E_RUINS_4").transform.position, 0.1f);
        }
        else
        {
            GoWhitMatrioshka();
        }
        Build = false;
    }

    void GoWhitMatrioshka()
    {
        if (this.CompareTag("BLUE_Trovo"))
        {
            transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("Matrioshkablue").transform.position, 0.1f);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position,
                GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.position, 0.1f);
        }

    }

}
