using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text puntuacion;
    public float currentTime;
    public float startinTime = 70;
    private int min,sec,cents;

    // Start is called before the first frame update
    void Start()
    {
        restarTiempo();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime -= 1 * Time.deltaTime;
        min =(int)(currentTime / 60f);
        sec =(int)(currentTime - min * 60f);
        cents = (int)((currentTime - (int)currentTime) * 100f);
        puntuacion.text = String.Format("{0:00}:{1:00}:{2:00}",min,sec,cents);
        if(currentTime <= 0){
            currentTime = 0;
            cents = 0;
        }
        
        //test
        if(puntuacion != null) {
            puntuacion.text = String.Format("{0:00}:{1:00}:{2:00}",min,sec,cents);
        }
        puntuacion.text = String.Format("{0:00}:{1:00}:{2:00}",min,sec,cents);
        // Debug.Log("min: " + min + ", sec: " + sec + ", cents: " + cents);
        
    }

    public void restarTiempo(){
        currentTime = startinTime;
    }
}
