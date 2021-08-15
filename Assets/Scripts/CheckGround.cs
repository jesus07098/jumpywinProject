using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded; //variable para verificar si el personaje ha tocado un suelo

    private void OnTriggerEnter2D(Collider2D collision) //si ha colisionado 
    {
        isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision) //si no está colisionando
    {
        isGrounded = false; 
    }
}
