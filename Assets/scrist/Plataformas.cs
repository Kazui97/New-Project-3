using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public Color prescolor;
    private Renderer rend;
    private Color starcolor;
    private GameObject caññon;
    void Start()
    {
        rend = GetComponent<Renderer>();
        starcolor = rend.material.color;
        
    }

    private void OnMouseDown()
    {
        if(caññon != null)
        {
            Debug.LogError("no puede contruir");
            return;
        }
        GameObject cannontobuild = Construirmanager.instance.cañonparaconstruir();
        caññon = (GameObject)Instantiate(cannontobuild, transform.position, transform.rotation);
    }

    private void OnMouseEnter()
    {
        rend.material.color = prescolor;
    }
    private void OnMouseExit()
    {
        rend.material.color = starcolor;
    }

    void Update()
    {
        
    }
}
