using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControleTrol : MonoBehaviour
{
    public NavMeshAgent control;
    public float vida_trol;
    void Start()
    {
        control.destination = GameObject.Find("villa").transform.position;
        vida_trol = 50;
    }
    private void OnCollisionEnter(Collision pego)
    {
        if(pego.gameObject.GetComponent<bala>())
        {
            vida_trol -= 5;
            if(vida_trol == 0)
            {
                Destroy(this.gameObject);
            }
            Debug.Log(vida_trol);
        }
    }

    void Update()
    {
        
    }
}
