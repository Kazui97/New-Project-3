using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    int temp;
    public GameObject enemigotrol;
    GameObject enemigotemp;
    int cantidad;

    void Start()
    {
     
        InvokeRepeating("Creaciontrol", 1, 50);
    }

    void Creaciontrol()
    {
        temp = (int)Time.timeSinceLevelLoad;
        if(temp >= 20)
        enemigotemp = Instantiate(enemigotrol, transform.position, Quaternion.identity);

    }
 
    void Update()
    {
        
    }
}
