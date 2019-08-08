using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    void Start()
    {
        int color = Random.Range(1, 4);
       switch (color)
        {
            case 1:
                this.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 2:
                this.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                this.GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }
    }
}
public struct DatosZombie
{
    enum GustoZ
    {
        Cerebro,
        Dedos,
        Cuello,
        Muslo,
        Orejas,
    }
}
