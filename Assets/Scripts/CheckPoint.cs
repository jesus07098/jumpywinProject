using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision) 
    { //si ha colisionado con un objeto 
        if(collision.CompareTag("Player"))
        { //si ha colisionado con el player
            collision.GetComponent<PlayerResp>().ReachedCheckPoint(transform.position.x,transform.position.y); //llamar metodo de player resp con el cual vamos a  guardar 
                                                                                                               //la posición cuando cruce un checkpoint
            GetComponent<Animator>().enabled = true; //activar animation de bandera ondeando
        }
    }
}
