using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerOnOff : MonoBehaviour
{
    public Button but;
    public Sprite OffSprite;
    public Sprite OnSprite;

    private int select = -1;

    private static string[] tag_highlight;
    private Variables variables;
    private Sprite[] images;

    private void Start()
    {
        variables = GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>();
        tag_highlight = variables.tag_highlight;
        images = variables.highlight_sprite;

    }

    public void OnOff()
    {
        Focus();

        if (but.image.sprite == OnSprite)
        {
            but.image.sprite = OffSprite;
            variables.selected[select] = false;
            var light = GameObject.FindGameObjectsWithTag(tag_highlight[select]);
            foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = null;

        }
        else
        {
            but.image.sprite = OnSprite;
            variables.selected[select] = true;
            var light = GameObject.FindGameObjectsWithTag(tag_highlight[select]);
            foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = images[select];
        }
    }

    public void Off()
    {
        Focus();
        variables.selected[select] = false;
        but.image.sprite = OffSprite;
        var light = GameObject.FindGameObjectsWithTag(tag_highlight[select]);
        foreach (GameObject l in light) l.GetComponent<SpriteRenderer>().sprite = null;

    }

    void Focus()
    {
        switch (but.name)
        {
            case "Button_Matrio":
                select = 0;
                break;
            case "Button_Babu":
                select = 1;
                break;
            case "Button_Trovo":
                select = 2;
                break;
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
