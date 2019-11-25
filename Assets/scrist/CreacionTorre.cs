using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionTorre : MonoBehaviour
{
   
    void Start()
    {
        
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
    public void torre()
    {

    }
}
