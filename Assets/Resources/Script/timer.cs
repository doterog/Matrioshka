using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

    public GUIText contador;
    public float tiempo = 0.0f;

    public void Update()
    {
        tiempo = tiempo - 1*Time.deltaTime;
        contador.text = "" + tiempo;
    }
}
