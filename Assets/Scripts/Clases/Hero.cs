using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    bool ColisionaZ;
    bool ColisionaC;
    void Start()
    {
        gameObject.transform.name = "HeroeNya";
        gameObject.AddComponent(typeof(Movement));
        GameObject Cabeza = new GameObject();
        Cabeza.AddComponent(typeof(Camera));
        Cabeza.AddComponent(typeof(CamaraH));//codigo de camara

        gameObject.GetComponent<Movement>().rotar = Cabeza.GetComponent<CamaraH>();
        Cabeza.transform.SetParent(gameObject.transform);
        Cabeza.transform.localPosition = new Vector3(0, 0.5f, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "ZombieNya")
        {
            Debug.Log(collision.transform.GetComponent<Zombie>().gustito);
        }
        else if (collision.transform.tag == "AldeanoNya")
            Debug.Log(collision.transform.GetComponent<Citizen>().meLlamo);
    }
}