using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Playercontrole : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    GameObject torre;
  Vector3 posinicial;

    void Start()
    {
        //agent.SetDestination(GameObject.Find("base").transform.position);
        torre = GameObject.FindGameObjectWithTag("torre");
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
    }
}
