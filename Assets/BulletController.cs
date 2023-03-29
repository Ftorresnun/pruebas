using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    [SerializeField]
    private float timeLife = 5f;

    private void OnTriggerEnter(Collider other){
        timer tiempo = GameObject.FindObjectOfType<timer>();
        if(other.GetComponent<Collider>().GetType() == typeof(BoxCollider)){
            if(tiempo != null)
            {
                tiempo.currentTime -= 5f;
                //modifica el texto en pantalla 
                tiempo.puntuacion.text = tiempo.currentTime.ToString("F2");//F2 indica que se muestren 2 decimales y formatea la cadena de texto a la nueva
                Debug.Log("resta");
            }
            Destroy(gameObject);
        }
        else{
            if(tiempo != null)
            {
                tiempo.currentTime += 10f;
                //modifica el texto en pantalla 
                tiempo.puntuacion.text = tiempo.currentTime.ToString("F2");//F2 indica que se muestren 2 decimales y formatea la cadena de texto a la nueva
                Debug.Log("sumando");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeLife);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }    
}
