using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC
{
    namespace Ally
    {
        public class Citizen : MonoBehaviour
        {//aca se declaran las variables a usar y se almacena los datos a mostrar para que no se cambien
            public DatosCitizen dato;
            public string meLlamo;
            void Start()
            {// meLlamo llama la funcion mensaje, tambien se le aplica el tag al gameobject para que se pueda reconcer
                gameObject.transform.tag = "AldeanoNya";
                meLlamo = eligeName();
            }
            public string eligeName()
            {//esta es la funcion que se encarga de imprimir el mensaje del nombre y la edad del ciudadano
                dato.age = Random.Range(15, 101);
                int randomN = Random.Range(0, 20);
                dato.NombresCiti = (Names)randomN;
                return "Hola, me llamo " + dato.NombresCiti + "y tengo " + dato.age + "años";
            }
        }
        public struct DatosCitizen
        {//en este struct se almacenan los datos de los nombres y la edad del ciudadano
            public Names NombresCiti;
            public int age;
        }
        //en este enum se encuentra los nombres de los ciudadanos
        public enum Names { Aydan, Chindler, Tann, Erock, Aerav, Daviron, Leviye, Tobis, Patrock, Abbrahan, Alaysia, Reegan, Catlea, Emiliye, Emilyse, Charleagh, Claissa, Belenne, Aebby, Allany }
    }
}