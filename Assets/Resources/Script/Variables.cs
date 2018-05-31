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
    //Variables para saber el color de la ruina, true = si es de un color, false = neutro
    int countRed;
    public bool[] colorRuinRed = new bool[4];
    int countBlue;
    public bool[] colorRuinBlue = new bool[4];

    void Update()
    {
        CountRuins();
    }

    void CountRuins()
    {
        countRed = 0;
        countBlue = 0;
        for(int i = 0; i!=4; i++)
        {
            if (colorRuinRed[i])
            {
                countRed++;
            }

            if (colorRuinBlue[i])
            {
                countBlue++;
            }
        }
        maxBabuskaBlue = 10 + (countBlue * 2);
        maxBabuskaRed = 10 + (countRed * 2);
    }

}
