using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidocamara : MonoBehaviour
{
    //public AudioClip sonidoglobal;
    AudioSource sonido;
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

   public void Parasonido()
    {
        sonido.Stop();
    }
    public void Activarsonido()
    {
        sonido.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
