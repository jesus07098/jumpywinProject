using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared; //texto de frutas recogidas
    private void Update()
    {
        AllFruitsCollected();
    }

    public void AllFruitsCollected() {

        if (transform.childCount == 0) {
            Debug.Log("No quedan frutas, Victoria");
            levelCleared.gameObject.SetActive(true); //activar texto de frutas recogidas
            Invoke("ChangeScene", 1); //invocar metodo de cambio de escena
        }

    }
    void ChangeScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //aumentar escena del build una más para que vaya a la siguiente y la cargue
    }
}
