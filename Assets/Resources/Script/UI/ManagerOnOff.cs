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
        }
    }

    public void Off()
    {
        but.image.sprite = OffSprite;
        On_Off = false;
    }

}
