using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) //cuando colisione con el personaje que posee el tag player
        {
            GetComponent<SpriteRenderer>().enabled = false; //con esto desactivariamos el sprite de las frutas
            gameObject.transform.GetChild(0).gameObject.SetActive(true);  //activamos el primer hijo del componente de la fruta 
                                                                          //llamado collected que posee una animación cada vez que se recoge una
            Destroy(gameObject, 0.5f); //destruir la fruta y lo que tiene en un tiempo de  0.5 s      
        }
}
}
