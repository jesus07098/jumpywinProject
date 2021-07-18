using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;

    private void Update() {
        AllFruitsColleted();
    }

    public void AllFruitsColleted() {
        if (transform.childCount == 0) {
            levelCleared.gameObject.SetActive(true);
            Debug.Log("No quedan frutas, Victoria");
        }
    }
}
