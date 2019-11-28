using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemycontroleEsqueleto : MonoBehaviour
{
   // public Camera cam;
    public NavMeshAgent agent;
     float vida_esqueleto = 40;

    //GameObject torre;
    //Vector3 posinicial;


    void Start()
    {
        
        agent.destination = GameObject.Find("villa").transform.position;
       // agent.SetDestination(GameObject.Find("base").transform.position);
       /* torre = GameObject.FindGameObjectWithTag("torre");
        posinicial = transform.position;
    }

    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }*/
    }
     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<bala>())
        {
            vida_esqueleto -=10;
            if(vida_esqueleto == 0)
            {
                Destroy(this.gameObject);
            }
           Debug.Log(vida_esqueleto);
        }
    }
}
