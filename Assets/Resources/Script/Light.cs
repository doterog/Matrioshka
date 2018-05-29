using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private bool state = false;


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
                    }
                    else
                    {
                        state = true;
                        light.SetActive(true);
                    }
            }

        }
        /*
                    Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    bool overSprite = this.GetComponent<SpriteRenderer>().bounds.Contains(touchPosition);

                    if (overSprite)
                    {
                        if (state)
                        {
                            state = false;
                            light.SetActive(false);
                        }
                        else
                        {
                            state = true;
                            light.SetActive(true);
                        }
                    }

                }
                */
    }



}
