using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    public Color prescolor;
    private Renderer rend;
    private Color starcolor;
    private GameObject caññon;


    Construirmanager construirmanager;

    void Start()
    {
       rend = GetComponent<Renderer>();
       starcolor = rend.material.color;

        construirmanager = Construirmanager.instance;
        
    }

    private void OnMouseDown()
    {
        if (construirmanager.Conseguircañonparaconstruir() == null)
        {
            return;
        }
        if(caññon != null)
        {
            Debug.LogError("no puede contruir");
            return;
        }
        GameObject cannontobuild =construirmanager.Conseguircañonparaconstruir();
        caññon = (GameObject)Instantiate(cannontobuild, transform.position, transform.rotation);
    }

    private void OnMouseEnter()
    {
        if (construirmanager.Conseguircañonparaconstruir() == null)
        {
            return;
        }
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
