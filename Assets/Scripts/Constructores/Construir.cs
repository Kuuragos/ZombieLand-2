using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construir : MonoBehaviour
{
    public GameObject HeroePre;

    void Start()
    {
        
        //aca el random range se usa para la cantidad de npcs de la escena y el For es el que lo controla e invoca al constructor
        int n = Random.Range(9, 20);
        
        for (int i = 0; i < n; i++)
        {
            
            int s = Random.Range(0, 2);
            if (s == 0)
            {
                Zombie zom = new Zombie();
            }
            else
            {
                Citizen ciu = new Citizen();
            }
            
        }
        GameObject heroe = Instantiate(HeroePre, Vector3.zero, Quaternion.identity);
        new Hero(heroe);
    }
    public class Hero
    {
        public Hero(GameObject heroe)
        {
            GameObject[] creaHeroes;
            creaHeroes = new GameObject[1];
            for (int i = 0; i < 1; i++)
            {
                Vector3 heroesPos = new Vector3();
                heroesPos.x = Random.Range(5, 30);
                heroesPos.z = Random.Range(5, 30);
                heroesPos.y = 1;
                heroe.transform.position = heroesPos;
                heroe = creaHeroes[i];
            }
        }
    }

    public class Zombie
    {
        //este es el constructor de los zombies
        string nombre;
        int color = Random.Range(1, 4);

        public Zombie()
        {
            GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Mobs.transform.position = v;


            string colorFinal = "";
            switch (color)
            {
                case 1:
                    Mobs.GetComponent<Renderer>().material.color = Color.cyan;
                    colorFinal = "cyan";
                    break;
                case 2:
                    Mobs.GetComponent<Renderer>().material.color = Color.green;
                    colorFinal = "green";
                    break;
                case 3:
                    Mobs.GetComponent<Renderer>().material.color = Color.magenta;
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
    public class Citizen
    {
        //este es el constructor de los ciudadanos
        public Citizen()
        {
            GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Mobs.transform.position = v;

            Debug.Log(Nombre());
        }
        string Nombre()
        {
            //esta matriz se usa para asignar a cada ciudadano su nombre y edad mediante un random range
            string[] names = new string[20];
            int nom = Random.Range(0, 20);
            int age = Random.Range(15, 101);
            names[0] = "Aydan";
            names[1] = "Chindler";
            names[2] = "Tann";
            names[3] = "Erock";
            names[4] = "Aerav";
            names[5] = "Daviron";
            names[6] = "Leviye";
            names[7] = "Tobis";
            names[8] = "Patrock";
            names[9] = "Abbrahan";
            names[10] = "Alaysia";
            names[11] = "Reegan";
            names[12] = "Catlea";
            names[13] = "Emiliye";
            names[14] = "Emilyse";
            names[15] = "Charleagh";
            names[16] = "Claissa";
            names[17] = "Belenne";
            names[18] = "Aebby";
            names[19] = "Allany";
            return "hola soy " + names[nom] + " y tengo " + age + " años";
        }
    }
}