using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public bool state = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            GameObject sprite = GameObject.FindGameObjectWithTag("RED_Trovo");
            if (sprite.GetComponent<SpriteRenderer>().bounds.Contains(touchPosition))
            {
                GameObject light = GameObject.FindGameObjectWithTag("RED_Trovo").transform.Find("HilightTrovo").gameObject;
                if (state)
                    {
                        state = false;
                        light.SetActive(false);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolTrovo=false;
                }
                else
                {
                        state = true;
                        light.SetActive(true);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolTrovo = true;
                }
            }

        }




        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            GameObject sprite = GameObject.FindGameObjectWithTag("MatrioshkaRed");
            if (sprite.GetComponent<SpriteRenderer>().bounds.Contains(touchPosition))
            {
                GameObject light = GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.Find("LightMatrio").gameObject;
                if (state)
                {
                    state = false;
                    light.SetActive(false);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolMatrio = false;
                }
                else
                {
                    state = true;
                    light.SetActive(true);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolMatrio = true;
                }
            }

        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            GameObject sprite = GameObject.FindGameObjectWithTag("RED_Babuska");
            if (sprite.GetComponent<SpriteRenderer>().bounds.Contains(touchPosition))
            {
                GameObject light = GameObject.FindGameObjectWithTag("RED_Babuska").transform.Find("LightBabuska").gameObject;
                if (state)
                {
                    state = false;
                    light.SetActive(false);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolBabus = false;
                }
                else
                {
                    state = true;
                    light.SetActive(true);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolBabus = true;
                }
            }

        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            GameObject sprite = GameObject.FindGameObjectWithTag("Ruin");
            if (sprite.GetComponent<SpriteRenderer>().bounds.Contains(touchPosition))
            {
                GameObject light = GameObject.FindGameObjectWithTag("Ruin").transform.Find("LightE_RUINS").gameObject;
                if (state)
                {
                    state = false;
                    light.SetActive(false);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolRuin = false;
                }
                else
                {
                    state = true;
                    light.SetActive(true);
                    GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolRuin = true;
                }
            }

        }

    }



}
