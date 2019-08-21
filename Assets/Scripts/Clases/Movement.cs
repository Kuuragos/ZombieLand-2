using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ //aca se declararon las variables que se van a utilizar
    public CamaraH rotar;
    public float speed;
    private void Start()
    {//aca se modifica la velocidad del heroe
        speed = Random.Range(0.1f, 0.3f);
    }

    void Update()
    {//Este bloque de IF se usa para el movimiento del heroe
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        transform.eulerAngles = new Vector3(0, rotar.MouseX, 0);
    }

}
