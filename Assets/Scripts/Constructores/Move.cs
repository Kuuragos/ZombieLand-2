using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //aca se declararon las variables que se van a utilizar
    float speed = 2.5f;
    float eje_X;
    public float force = 250f;
    public bool canJump = false;

    void Start()
    {
        //aca el random range se usa para la cantidad de npcs de la escena y el For es el que lo controla e invoca al constructor
        int n= Random.Range(4, 10);
        
        for (int i = 0; i < n; i++)
        {
            int s = Random.Range(0, 2);
            if (s==0)
            {
                Zombie zom = new Zombie(0, 10);
            }
            else
            {
                Citizen ciu = new Citizen();
            }
            
        }
        
    }
    
    void Jump()
    {
        //verifica el rigidbody y aplica la fuerza gravitatoria
        if (canJump)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
                }
    }
    void Update()
    {
        //Este bloque de IF se usa para el movimiento del heroe
        eje_X += Input.GetAxis("Mouse X");

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2.5f;
           
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 5;
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            canJump = false;

        }
        transform.eulerAngles = new Vector3(0, eje_X, 0);

    }
    public class Zombie
    {
        //este es el constructor de los zombies
         string nombre;
         int cerebros;
         int golpe;
        int color = Random.Range(1, 4);

        public Zombie(int cerebros, int golpe)
        {
            GameObject Mobs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(5, 30);
            v.z = Random.Range(5, 30);
            Mobs.transform.position = v;

            
            this.golpe = golpe;
            this.cerebros = cerebros;
            string colorFinal="";
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
    private void OnCollisionEnter(Collision collision)
    {
        // comprueba si hay una colision con el terreno para permitir al Heroe saltar
        if (collision.transform.name=="Terrain")
        {
            canJump = true;
        }
    }
}
