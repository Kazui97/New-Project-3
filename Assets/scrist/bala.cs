using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{   
    Rigidbody rigi;
    public Vector3 direccion;
    void Awake()
    {
        rigi = GetComponent<Rigidbody>();
    }
   void Start()
    {
        rigi.AddRelativeForce(direccion*15,ForceMode.Impulse);
    }

    public void OnCollisionEnter(Collision col)
    {
       /*if (col.gameObject.GetComponent<enemigo>() )
        {
            Destroy(this.gameObject);
        }*/
    }
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0);
        
    }
}
