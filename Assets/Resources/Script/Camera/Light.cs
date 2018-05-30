using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{

    private static string[] tag_units;
    private static string[] tag_highlight;
    private Variables variables;
    private Sprite[] imagenes;

    // Use this for initialization
    void Start()
    {
        variables = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>();
        tag_units = variables.tag_units;
        tag_highlight = variables.tag_highlight;
        imagenes = variables.highlight_sprite;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            for (int i = 0; i < tag_units.Length; i++)
            {

                GameObject[] sprite = GameObject.FindGameObjectsWithTag(tag_units[i]);

                for (int x = 0; x < sprite.Length; x++)
                {
                    if (sprite[x].GetComponent<SpriteRenderer>().bounds.Contains(touchPosition))
                    {
                        Debug.Log("TOQUE!");

                        if (variables.selected[i])
                        {
                            variables.selected[i] = false;
                            var light = GameObject.FindGameObjectsWithTag(tag_highlight[i]);
                            foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = null;



                        }
                        else
                        {
                            variables.selected[i] = true;
                            var light = GameObject.FindGameObjectsWithTag(tag_highlight[i]);
                            foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = imagenes[i];
                        }

                        Deselect(i);

                        x = sprite.Length;
                        i = tag_units.Length;
                    }
                }
            }
        }

    }
    void Deselect(int i)
    {
        for (int x = 0; x < variables.selected.Length; x++)
        {
            if (variables.selected[x] == true && x != i)
            {
                variables.selected[x] = false;
                var light = GameObject.FindGameObjectsWithTag(tag_highlight[x]);
                foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = null;
            }
        }

    }
}
