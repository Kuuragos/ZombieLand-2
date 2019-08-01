using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //aca se declararon las variables que se van a utilizar
    float speed = 2.5f;
    float eje_X;

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
        transform.eulerAngles = new Vector3(0, eje_X, 0);

    }
}
