using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
     public GameObject bala;
     public GameObject canon;
     GameObject lasbalas;
    public Transform objetivo;
    public float vision;
    GameObject player;
    Vector3 posinicial;
   

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        posinicial = transform.position;
    }


    void Lasbalas()
    {
        lasbalas = Instantiate(bala , canon.GetComponent<Transform>().position,Quaternion.identity);
        lasbalas.transform.parent = null;
        lasbalas.GetComponent<bala>().direccion = transform.forward;
        lasbalas.name = "balasprueba";
        Destroy(lasbalas,1.5f);

    }

    void Update()
    {

        Vector3 target = posinicial;
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < vision)
        {
             transform.LookAt(objetivo);
             Lasbalas();
            Debug.Log("en la mira");
        }



       
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, vision);
    }
}
