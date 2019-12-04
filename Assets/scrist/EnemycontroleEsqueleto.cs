using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemycontroleEsqueleto : MonoBehaviour
{
   // public Camera cam;
   Construirmanager construirmanager;
    public NavMeshAgent agent;
    float vida_max = 40;
     float vida_esqueleto;
    public Image vida_imagen;
    // Animator animator;

    //GameObject torre;
    //Vector3 posinicial;

    private void Awake()
    {
       // animator = GetComponent<Animator>();
    }
    void Start()
    {  
        construirmanager = Construirmanager.instance;
        agent.destination = GameObject.Find("villa").transform.position;
        vida_esqueleto = vida_max;
       // animator.enabled = false;

    }

   
    void Update(){
    
    }
    void Hp_esqueleto()
    {
        vida_imagen.fillAmount = (1 / vida_max) * vida_esqueleto;
    }
     void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<bala>())
        {
            vida_esqueleto -=10;
            if(vida_esqueleto == 0)
            {
                construirmanager.monedas += Random.Range(10,50);
                // animator.enabled = true;
                //Invoke("DEstruir", 1);
                Destroy(this.gameObject);
                Debug.Log( construirmanager.monedas );
            }
           Debug.Log(vida_esqueleto);
            Hp_esqueleto();
        }
     }
    void DEstruir()
    {
        Destroy(this.gameObject);
       // animator.enabled = false;
    }
}

