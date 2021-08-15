using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpike : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) //si el player ha colisionado con alguna pulla Spike 
        {
            Debug.Log("Player Damaged");
            Destroy(collision.gameObject); //se muere destruyendo el gameobject del player
            
        }
    }
}
