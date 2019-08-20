using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct DatosZombie
{
    public GustoZ gz;
    public Comportamientos cz;
    public int gusto;
    
}
public enum GustoZ
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

public class Zombie : MonoBehaviour
{
    public DatosZombie dato;
    public int rotar;
    public float rotarZ = 3f;
    public float speedZ = 2f;
    public string gustito;

    void Start()
    {
        gustito = Mensaje();
        gameObject.transform.tag = "ZombieNya";
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
       
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        while (true)
        {
            int estado = Random.Range(0, 2);
            switch (estado)
            {
                case 0:
                    dato.cz = Comportamientos.Idle;
                    rotar = Random.Range(0, 2);
                    break;
                case 1:
                    dato.cz = Comportamientos.Moving;
                    break;
            }
            switch (rotar)
            {
                case 0:
                    rotarZ = -rotarZ;
                    break;
            }
            yield return new WaitForSeconds(5f);
        }
      
    }
    public string Mensaje()
    {
        dato.gusto = Random.Range(0, 5);
        dato.gz = (GustoZ)dato.gusto;
        return "RAWWRRRR!! quiero comer " + dato.gz;
    }
    public void Update()
    {
        if (dato.cz == Comportamientos.Moving)
            transform.position += transform.forward * speedZ * Time.deltaTime;
        
    }
}


