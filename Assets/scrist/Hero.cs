using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
   
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<EnemyControleTrol>())
        {
            Debug.Log("trol lleguo");
        }

    }
        
   
    void Update()
    {
        
    }
}
