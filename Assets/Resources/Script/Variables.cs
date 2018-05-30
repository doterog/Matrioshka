using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
    //Variables vida muñecos.
    public int vidaMatrioska = 200,
               vidaTrovo = 50,
               vidaBabuska = 20;
    //Variables maximo totales de muñecos.
    public int maxBabuskaRed = 10,
               maxBabuskaBlue = 10;
    //Variables relacionados con el movimiento y posicion
    public float detectarEnemigo = 1;
    public float detectarRuina = 1;
    public float detectarMatrioskaAliada = 1;
    public Vector3 detectarMatrioskaAliadaV3 = new Vector3(1, 1, 1);
    //Variables bool que dicen qual esta seleccionado o no;
    public bool boolMatrio = false, boolTrovo = false, boolBabus = false, boolRuin = false;
    
}
