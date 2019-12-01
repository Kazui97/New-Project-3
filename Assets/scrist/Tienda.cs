using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    Construirmanager construirmanager;
    public int oro;

    private void Start()
    {
        construirmanager = Construirmanager.instance;  //  adcedemos al scrit gracias a que es estatico
    }




    public void Comprarcañon()          // no se como explicar :|  /// aqui adcedemos al prefad seleccionado para porder adceder a el desde los botones 
    {
        construirmanager.Establecercañonparaconstruir(construirmanager.cañonprefab);
    }
    public void Comprarcañon2()
    {
        construirmanager.Establecercañonparaconstruir(construirmanager.cañon2prefad);
    }
    public void Comprarcaño3()
    {
        construirmanager.Establecercañonparaconstruir(construirmanager.cañon3prefad);
    }
    
}
