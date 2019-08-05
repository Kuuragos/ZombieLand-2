using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    
    void Start()
    {
        int color = Random.Range(1, 4);
        string colorFinal = "";
        switch (color)
        {
            case 1:
                this.GetComponent<Renderer>().material.color = Color.cyan;
                colorFinal = "cyan";
                break;
            case 2:
                this.GetComponent<Renderer>().material.color = Color.green;
                colorFinal = "green";
                break;
            case 3:
                this.GetComponent<Renderer>().material.color = Color.magenta;
                colorFinal = "magenta";
                break;
        }
        Debug.Log(soyZ(colorFinal));

    }
    //aqui se retorna el color de los zombies a la funcion debug.log
    string soyZ(string color)
    {
        return "Soy un zombie de color " + color;
    }
}

