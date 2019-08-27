using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NPC.Enemy;
using NPC.Ally;

public class Crear : MonoBehaviour
{
    public Text ZombieT;
    public Text CitiT;
    readonly int Qcubo;
    public Crear()
    {
        //se declara el valor random de los cubos
        System.Random rnd = new System.Random();
        Qcubo = rnd.Next(5, 16);
    }
    public static float heroSpeed;
    public void Awake()
    {
        //se declara el valor random de la velocidad del heroe
        heroSpeed = Random.Range(0.1f, 0.5f);
    }
    void Start()
    { 
        for (int i = 0; i < Qcubo; i++) //este for crea los cubos y mediante un if se decide crear entre el heroe, zombies y ciudadanos llamando a sus clases
        {
            int s = Random.Range(1, 3);
            GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Mobs.AddComponent<Rigidbody>();
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Mobs.transform.position = v;
            if (i == 0)
            {
                Mobs.AddComponent(typeof(Hero));
            }

            else
            {
                switch (s)
                {
                    case 1:
                        Mobs.AddComponent(typeof(Zombie));
                        break;
                    case 2:
                        Mobs.AddComponent(typeof(Citizen));
                        break;
                }
            }
        }
        int citiC = 0;
        int zombieC = 0;
        foreach (Zombie zombie in Transform.FindObjectsOfType<Zombie>())
        {
            zombieC = zombieC + 1;
            ZombieT.text = "Zombies: " + zombieC;
        }
        foreach (Citizen ciudadanos in Transform.FindObjectsOfType<Citizen>())
        {
            citiC = citiC + 1;
            CitiT.text = "Ciudadanos:" + citiC;
        }
    }
}
