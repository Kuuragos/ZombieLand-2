using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct DatosZombie
{
    
}
public class Zombie : MonoBehaviour
{
    enum GustoZ
    {
        Cerebro,
        Dedos,
        Cuello,
        Muslo,
        Orejas,
    }
    public enum Comportamientos
    {
        Idle,
        Moving,
    }
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
        StartCoroutine(Wait(2));
    }
    IEnumerator Wait(float seconds)
    {
     int posicion= Random.Range(1,5);
     float speed = 0.5f;
     Comportamientos Comportar =(Comportamientos )Random.Range(0,2);
     yield return new WaitForSeconds(2);
        switch (Comportar)
        {
            case Comportamientos.Idle:
                transform.position = transform.position;
            break;
            case Comportamientos.Moving:
                switch (posicion)
                {
                    case 1:
                        transform.position += transform.forward * speed;
                    break;
                    case 2:
                        transform.position -= transform.forward * speed;
                        break;
                    case 3:
                        transform.position += transform.right * speed;
                        break;
                    case 4:
                        transform.position -= transform.right * speed;
                        break;
                }
                
            break;
        }
      StartCoroutine(Wait(2));
    }
}


