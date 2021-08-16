using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResp : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY; //variables para guardar las coordenadas punto cuando pase por el checkpoint

    void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX")!= 0) //si no se ha asignado nada
        {
            //cambiar personaje a la posición del checkpoint
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY"))); 
        }
    }

    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x); //para guardar información de la posición x
        PlayerPrefs.SetFloat("checkPointPositionY", y); //para guardar información de la posición y
    }

}
