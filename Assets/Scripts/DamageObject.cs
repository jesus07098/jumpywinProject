using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
   {
       if (collision.transform.CompareTag("Player")) { //si el personaje con la etiqueta player ha colisionado con un enemigo
           Debug.Log("Player Damaged");
           Destroy(collision.gameObject);       //se desaparece el personaje con destroy
       
       }
   }
}
