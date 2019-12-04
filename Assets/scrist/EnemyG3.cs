using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyG3 : MonoBehaviour
{
    int temp;
    public GameObject enemigogolem;
    GameObject enemigotemp;
    int cantidad;

    void Start()
    {
       
        InvokeRepeating("Creaciongolem", 1, 30);
        
       
    }

    void Creaciongolem()
    {
        temp = (int)Time.timeSinceLevelLoad;
        if (temp >= 30)
            enemigotemp = Instantiate(enemigogolem, transform.position, Quaternion.identity);

    }

    void Update()
    {

    }
}
