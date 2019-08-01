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
   
    private void OnCollisionEnter(Collision collision)
    {
        // comprueba si hay una colision con el terreno para permitir al Heroe saltar
        if (collision.transform.name=="Terrain")
        {
            canJump = true;
        }
    }
}
