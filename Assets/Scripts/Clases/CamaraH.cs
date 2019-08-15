using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraH : MonoBehaviour
{
    public float MouseX;
    float MouseY;
    float sensibilidad = 3.5f;
    float limitarvista;
    public bool invertedMouse;
    void Update()
    {
        float rotarx = Input.GetAxisRaw("Mouse X");
        MouseX += rotarx * sensibilidad;

        float rotary = Input.GetAxisRaw("Mouse Y");
        float campo = rotary * sensibilidad;

        Vector3 mousePosition = Input.mousePosition;
        MouseX += Input.GetAxis("Mouse X");
        if (invertedMouse)
        {
            limitarvista += campo;
        }
        else
        {
            limitarvista -= campo;
        }
        transform.eulerAngles = new Vector3(limitarvista, MouseX, 0);
    }
}
