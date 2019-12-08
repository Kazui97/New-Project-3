using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
   
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyControleTrol>())
        {
            Debug.Log("trol lleguo");
        }

    }
        
   
    void Update()
    {
        
    }
}
