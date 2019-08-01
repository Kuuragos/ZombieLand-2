using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    int h = 0;
    void Start()
    {
        int n = Random.Range(9, 20);
        for (int i = 0; i < n; i++)
        {
            int s = Random.Range(0, 3);
            if (s == 0 && h == 0)
            {
                h = 1;
            }
            else if(s==1)
            {
                GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Vector3 v = new Vector3();
                v.x = Random.Range(5, 30);
                v.z = Random.Range(5, 30);
                Mobs.transform.position = v;
            }
            else if(s==2)
            {
                GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Vector3 v = new Vector3();
                v.x = Random.Range(5, 30);
                v.z = Random.Range(5, 30);
                Mobs.transform.position = v;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
