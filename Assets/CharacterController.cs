using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{   
    [SerializeField]
    public float speed = 3;
    public Rigidbody rb;
    public float dashSpeed = 10;

    // Update is called once per frame
    private void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(dir * dashSpeed, ForceMode.Impulse);
        }
        rb.velocity = dir * speed;
    }

    // private void OnTriggerEnter(Collider other){
    //     if(other.CompareTag("bala") && other.GetComponent<Collider>().GetType() == typeof(SphereCollider)){
    //         timer tiempo = GameObject.FindObjectOfType<timer>();
    //         if(tiempo != null)
    //         {
    //             tiempo.currentTime += 10f;
    //             //modifica el texto en pantalla 
    //             tiempo.puntuacion.text = tiempo.currentTime.ToString("F2");//F2 indica que se muestren 2 decimales y formatea la cadena de texto a la nueva
    //             Debug.Log("suma");
    //         }
    //     }
    // }
}
