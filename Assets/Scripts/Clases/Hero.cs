using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;

public class Hero : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.name = "HeroeNya"; //aca se le da el tag al gameobject del heroe
        gameObject.AddComponent(typeof(Movement));
        GameObject Cabeza = new GameObject();
        Cabeza.AddComponent(typeof(Camera)); //este añade la camara
        Cabeza.AddComponent(typeof(CamaraH));//este añade el codigo de camara

        gameObject.GetComponent<Movement>().rotar = Cabeza.GetComponent<CamaraH>(); //aca se pone como hijo del heroe a la camara
        Cabeza.transform.SetParent(gameObject.transform);
        Cabeza.transform.localPosition = new Vector3(0, 0.5f, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //aca se verifica con que tipo de objeto se hizo colision y se imprime sus respectivos mensajes
        if (collision.transform.tag == "ZombieNya")
        {
            Debug.Log(collision.transform.GetComponent<Zombie>().gustito);
        }
        else if (collision.transform.tag == "AldeanoNya")
            Debug.Log(collision.transform.GetComponent<Citizen>().meLlamo);
    }
}