using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : MonoBehaviour
{
    public DatosCitizen dato;
    public string meLlamo;
    void Start()
    {
        gameObject.transform.tag = "AldeanoNya";
        meLlamo = eligeName();
    }
    public string eligeName()
    {
        dato.age = Random.Range(15, 101);
        int randomN = Random.Range(0, 20);
        dato.NombresCiti = (Names)randomN;
        return "Hola, me llamo " + dato.NombresCiti + "y tengo " + dato.age + "años";
    }
}
public struct DatosCitizen
{
    public Names NombresCiti;
    public int age;
}

public enum Names {Aydan,Chindler,Tann,Erock,Aerav,Daviron,Leviye,Tobis,Patrock,Abbrahan,Alaysia,Reegan,Catlea,Emiliye,Emilyse,Charleagh,Claissa,Belenne,Aebby,Allany}
