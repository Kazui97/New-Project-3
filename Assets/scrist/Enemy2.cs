using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyG2 : MonoBehaviour
{
    
    public GameObject enemigotrol;
    GameObject enemigotemp;
    int cantidad;

    void Start()
    {
       // CreacionEsqueletos();
        InvokeRepeating("Creaciontrol", 1, 10);
    }

    void Creaciontrol()
    {
         enemigotemp = Instantiate(enemigotrol, transform.position, Quaternion.identity);

    }
 
    void Update()
    {
        
    }
}
