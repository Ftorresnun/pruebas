using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    // Update is called once per frame
    void Update()
    {   
        //encontrar la direccion del objetivo
        Vector3 direction = target.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.red);

        //slerp para rotar
        Quaternion lookRotation = Quaternion.LookRotation(direction);//crea una rotacion que mira hacia la direccion
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime);//el slerp coge mi rotacion actual y la rotacion que quiero y me da una rotacion intermedia
    }
}
