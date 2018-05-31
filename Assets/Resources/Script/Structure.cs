using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour {

    public GameObject RedRuin, BlueRuin;
    
    Vector3 positionInitial = new Vector3();

    void Start()
    {
        positionInitial = this.transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        this.transform.localRotation = Quaternion.Euler(0, 0, 0);
        this.transform.position = positionInitial;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RED_Trovo")
        {
            if (this.name == ("E_RUINS_1"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinRed[0] = true;
            }

            if (this.name == ("E_RUINS_2"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinRed[1] = true;
            }

            if (this.name == ("E_RUINS_3"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinRed[2] = true;
            }

            if (this.name == ("E_RUINS_4"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinRed[3] = true;
            }

        }

        if (collision.gameObject.tag == "BLUE_Trovo")
        {
            if (this.name == ("E_RUINS_1"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinBlue[0] = true;
            }

            if (this.name == ("E_RUINS_2"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinBlue[1] = true;
            }

            if (this.name == ("E_RUINS_3"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinBlue[2] = true;
            }

            if (this.name == ("E_RUINS_4"))
            {
                GameObject.Find("VariablesGlobales").GetComponent<Variables>().colorRuinBlue[3] = true;
            }
        }
    }
}
