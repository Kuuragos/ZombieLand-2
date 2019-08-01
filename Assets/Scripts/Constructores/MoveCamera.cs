using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // se declararon las variables y el bool a usar
    float mouseX;
    float mouseY;
    public bool inversionMouse;

    void Update()
    {
        // aca se registra el movimiento del mouse en x & y
        Vector3 mousePosition = Input.mousePosition;
        mouseX += Input.GetAxis("Mouse X");
        if (inversionMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");

        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
