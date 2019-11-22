using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemycontrole : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    GameObject torre;
    Vector3 posinicial;

    void Start()
    {
        agent.destination = (GameObject.Find("base").transform.position);
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
            Destroy(this.gameObject);
        }
    }
}
