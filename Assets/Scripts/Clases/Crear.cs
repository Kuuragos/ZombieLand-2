using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    void Start()
    { //se declara el valor random de los cubos
        int n = Random.Range(10, 21);
        for (int i = 0; i < n; i++) //este for crea los cubos y mediante un if se decide crear entre el heroe, zombies y ciudadanos llamando a sus clases
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
    }
}
