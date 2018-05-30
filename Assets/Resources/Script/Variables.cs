using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
    //Variables vida muñecos.
    public int vidaMatrioska = 200,
               vidaTrovo = 50,
               vidaBabuska = 20;
    //Variables maximo totales de muñecos.
    public int totalBabuska = 0,
               maxBabuska = 10;
    //Variables relacionados con el movimiento y posicion
    public float detectarEnemigo = 1;
    public float detectarRuina = 1;
    public float detectarMatrioskaAliada = 1;
    //Variables bool que dicen qual esta seleccionado o no;
    public  bool[] selected = new bool[4];
    // 0 = Matrioshka
    // 1 = Babushka
    // 2 = Trovo
    // 3 = E_Ruins
    public  string[] tag_units = { "RED_Matrioshka", "RED_Babuska", "RED_Trovo" };
    public  string[] tag_highlight = { "L_Matrioshka", "L_Babuska", "L_Trovo" };
    public Sprite[] highlight_sprite = new Sprite[3];

}
