using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorGolem : MonoBehaviour

{
    Construirmanager construirmanager;
    public NavMeshAgent agent;
    float vida_golem = 200;
    Animator animator;

    //GameObject torre;
    //Vector3 posinicial;


    void Start()
    {
        construirmanager = Construirmanager.instance;
        agent.destination = GameObject.Find("villa").transform.position;
    }


    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<bala>())
        {
            vida_golem -= 10;
            if (vida_golem == 0)
            {
                construirmanager.monedas += Random.Range(10, 50);
                Destroy(this.gameObject);
                Debug.Log(construirmanager.monedas);
            }
            Debug.Log(vida_golem);
        }
    }
}

