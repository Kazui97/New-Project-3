﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ControladorGolem : MonoBehaviour

{
    Construirmanager construirmanager;
    public NavMeshAgent agent;
    public float vida_max = 200;
    float vida_golem;
    public Image hpgolem;
    Animator animator;

    //GameObject torre;
    //Vector3 posinicial;


    void Start()
    {
        construirmanager = Construirmanager.instance;
        agent.destination = GameObject.Find("villa").transform.position;
        vida_golem = vida_max;
    }


    void Update()
    {

    }
    void Hpgolem()
    {
        hpgolem.fillAmount = (1 / vida_max) * vida_golem;
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<bala>())
        {
            vida_golem -= 10;
            if (vida_golem == 0)
            {
                construirmanager.monedas += Random.Range(50, 100);
                Destroy(this.gameObject);
                Debug.Log(construirmanager.monedas);
            }
            Hpgolem();
            Debug.Log(vida_golem);
        }
    }
}

