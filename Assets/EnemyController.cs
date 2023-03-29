using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private float shootsBetween = 2f;
    [SerializeField]
    private int cantBalas;
    public GameObject spawnPoint;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        //spawn bullet from spawnPoint
        
    }

    IEnumerator Shoot(){
        Debug.Log("start shooting");
        for(int i=0; i < cantBalas; i++){
            cantBalas++;
            Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
            yield return new WaitForSeconds(shootsBetween);
        }
        Debug.Log("stop shooting");
    }
}
