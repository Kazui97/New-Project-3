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
    Vector3 posinicial;
   

    void Start()
    {
        //enemigo = GameObject.FindGameObjectWithTag("Enemigo");
        posinicial = transform.position;
        InvokeRepeating("Disparo", 0.1f, 0.1f);
        Enemigoenlamira();
        
    }
    void Lasbalas()
    {
        lasbalas = Instantiate(bala , canon.GetComponent<Transform>().position,Quaternion.identity);
        lasbalas.transform.parent = null;
        lasbalas.GetComponent<bala>().direccion = transform.forward;
        lasbalas.name = "balasprueba";
        Destroy(lasbalas,1.5f);
    }

    void Disparo()
    {
        transform.LookAt(objetivo);
        if (Vector3.Distance(transform.position, objetivo.position)<=vision){
            Enemigoenlamira();
            Lasbalas();
        }
       /* * Vector3 target = posinicial;
        float dist = Vector3.Distance(enemigo.transform.position, transform.position);
        if (dist < vision)
        {
            transform.LookAt(objetivo);
            Lasbalas();
            Debug.Log("en la mira");
        }*/
    }
    void Enemigoenlamira()
    {
        GameObject[] enemigo = GameObject.FindGameObjectsWithTag("Enemigo");
        objetivo = enemigo[0].transform;
        for (int i = 0; i < enemigo.Length; i++)
        {
            if(Vector3.Distance(transform.position,enemigo[i].GetComponent<Transform>().position)<Vector3.Distance(transform.position, objetivo.position)){
                objetivo = enemigo[i].transform;
            }
        }
    }
    void Update()
    {
        Enemigoenlamira();     
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, vision);
    }
}
