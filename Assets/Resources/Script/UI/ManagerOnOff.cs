using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerOnOff : MonoBehaviour
{
    public Button but;
    public Sprite OffSprite;
    public Sprite OnSprite;


    public void OnOff()
    {
        if (but.image.sprite == OnSprite)
            but.image.sprite = OffSprite;
        else
        {
            but.image.sprite = OnSprite;
        }
    }

    public void Off()
    {
            but.image.sprite = OffSprite;
    }

}
