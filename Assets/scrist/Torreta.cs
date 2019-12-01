using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public GameObject bala;
    public GameObject canon;
    int temp;
    GameObject lasbalas;
    public Transform objetivo;
    public Transform objetivo2;
    public float vision;
   // Vector3 posinicial;
   

    void Start()
    {
        //enemigo = GameObject.FindGameObjectWithTag("Enemigo");
       // posinicial = transform.position;
        InvokeRepeating("Disparo", 0.01f, 1f);
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
        transform.LookAt(objetivo2);
        if (Vector3.Distance(transform.position, objetivo.position)<=vision){
            Enemigoenlamira();
            Lasbalas();
        }
        else if(Vector3.Distance(transform.position, objetivo2.position) <= vision)
        {
            Enemigo2enlamira();
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
        temp = (int)Time.timeSinceLevelLoad;
        if (temp >= 5)
        {
            GameObject[] enemigo = GameObject.FindGameObjectsWithTag("Enemigo");
            objetivo = enemigo[0].transform;
            for (int i = 0; i < enemigo.Length; i++)
            {
                if (Vector3.Distance(transform.position, enemigo[i].GetComponent<Transform>().position) < Vector3.Distance(transform.position, objetivo.position))
                {
                    objetivo = enemigo[i].transform;
                }
            }
        }
        
    }
    void Enemigo2enlamira()
    {
        temp = (int)Time.timeSinceLevelLoad;
        if (temp >= 11)
        {
            GameObject[] enemigo2 = GameObject.FindGameObjectsWithTag("Enemigo2");
            objetivo2 = enemigo2[0].transform;
            for (int i = 0; i < enemigo2.Length; i++)
            {
                if (Vector3.Distance(transform.position, enemigo2[i].GetComponent<Transform>().position) < Vector3.Distance(transform.position, objetivo2.position))
                {
                    objetivo2 = enemigo2[i].transform;
                }
            }
        }
       
    }
    void Update()
    {
        Enemigoenlamira();
        Enemigo2enlamira();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, vision);
    }
}
