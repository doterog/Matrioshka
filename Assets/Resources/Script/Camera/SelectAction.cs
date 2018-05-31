using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectAction : MonoBehaviour
{

    private static string[] tag_units;
    private static string[] tag_highlight;
    private static Button[] _buttons;
    private Variables variables;
    private Sprite[] images_hlight;
    private bool touch = false;


    // Use this for initialization
    void Start()
    {
        variables = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>();
        tag_units = variables.tag_units;
        tag_highlight = variables.tag_highlight;
        _buttons = variables._buttons;
        images_hlight = variables.highlight_sprite;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            // Active or desactive a Unit
            for (int i = 0; i < tag_units.Length; i++)
            {

                GameObject[] sprite = GameObject.FindGameObjectsWithTag(tag_units[i]);

                for (int x = 0; x < sprite.Length; x++)
                {
                    if (sprite[x].GetComponent<SpriteRenderer>().bounds.Contains(touchPosition))
                    {
                        touch = true;

                 

                        if (variables.selected[i])
                        {
                            variables.selected[i] = false;
                            var light = GameObject.FindGameObjectsWithTag(tag_highlight[i]);
                            foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = null;

                            _buttons[i].image.sprite = variables.buttons_spriteOff[i];


                        }
                        else
                        {
                            variables.selected[i] = true;
                            var light = GameObject.FindGameObjectsWithTag(tag_highlight[i]);
                            foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = images_hlight[i];
                            _buttons[i].image.sprite = variables.buttons_spriteOn[i];
                        }

                        Deselect_Others(i);

                        x = sprite.Length;
                        i = tag_units.Length;
                    }
                }
            }

            // Move an Active unit if any selected
            if (!touch)
            {

                for (int i = 0; i < variables.selected.Length; i++)
                {

                    if (variables.selected[i])
                    {
                        Debug.Log(variables.tag_units[i]);
                        Debug.Log(touchPosition.ToString());

                        var units = GameObject.FindGameObjectsWithTag(variables.tag_units[i]);
                        foreach (GameObject unit in units)
                        {
                           unit.GetComponent<MoveTo>().MoveToPosition(touchPosition);
                        }
                    }
                }
            }
          
            touch = false;
        }

    }

    void Deselect_Others(int i)
    {
        for (int x = 0; x < variables.selected.Length; x++)
        {
            if (variables.selected[x] == true && x != i)
            {
                variables.selected[x] = false;
                var light = GameObject.FindGameObjectsWithTag(tag_highlight[x]);
                foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = null;
                _buttons[x].image.sprite = variables.buttons_spriteOff[x];
            }
        }

    }
}
