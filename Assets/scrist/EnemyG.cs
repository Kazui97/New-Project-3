using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyG : MonoBehaviour
{
    public GameObject enemigoesqueleto;
    GameObject enemigotemp;
    int cantidad;

    void Start()
    {
       // CreacionEsqueletos();
        InvokeRepeating("CreacionEsqueletos", 1, 4);
    }

    void CreacionEsqueletos()
    {
         enemigotemp = Instantiate(enemigoesqueleto, transform.position, Quaternion.identity);

    }
 
    void Update()
    {
        
    }
}
