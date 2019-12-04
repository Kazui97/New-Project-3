using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyControleTrol : MonoBehaviour
{
    Construirmanager construirmanager;
    public NavMeshAgent control;
    public float vida_max = 50;
     float vida_trol;
    public Image hptroll;
    void Start()
    {
        construirmanager = Construirmanager.instance;
        control.destination = GameObject.Find("villa").transform.position;
        vida_trol = vida_max;
    }


    void Hptrol()
    {
        hptroll.fillAmount = (1 / vida_max) * vida_trol;
    }

    private void OnCollisionEnter(Collision pego)
    {
        if(pego.gameObject.GetComponent<bala>())
        {
            vida_trol -= 5;
            if(vida_trol == 0)
            {
                construirmanager.monedas += Random.Range(30, 70);
                Destroy(this.gameObject);
            }
            Debug.Log(vida_trol);
            Hptrol();
        }
    }

    void Update()
    {
        
    }
}
