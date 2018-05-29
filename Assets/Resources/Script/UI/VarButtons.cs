using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOff_Image : MonoBehaviour {

    public Sprite Babu_OffSprite;
    public Sprite Babu_OnSprite;
    public Button Babu_Button;

    void Update()
    {
        if (GameObject.Find("Matrio").GetComponent<ManagerOnOff>().On_Off)
        {
            GameObject light = GameObject.FindGameObjectWithTag("MatrioshkaRed").transform.Find("LightMatrio").gameObject;

            
            {
                GameObject.Find("Main Camera").GetComponent<Light>().state = true;
                light.SetActive(true);
                GameObject.FindGameObjectWithTag("variables").GetComponent<Variables>().boolMatrio = true;
            }
        }

    }
    

}
