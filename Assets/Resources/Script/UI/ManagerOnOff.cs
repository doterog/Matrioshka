using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerOnOff : MonoBehaviour
{
    public Button but;
    public Sprite OffSprite;
    public Sprite OnSprite;
    public bool On_Off;


    public void OnOff()
    {
        if (but.image.sprite == OnSprite) { 
            but.image.sprite = OffSprite;
            On_Off = false;
        }
        else
        {
            but.image.sprite = OnSprite;
            On_Off = true;
            GameObject light = GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.Find("LightMatrio").gameObject;
            {
                GameObject.Find("Main Camera").GetComponent<Light>().state = true;
                light.SetActive(true);
                GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolMatrio = true;
            }
        }
    }

    public void Off()
    {
        but.image.sprite = OffSprite;
        On_Off = false;
    }

}
