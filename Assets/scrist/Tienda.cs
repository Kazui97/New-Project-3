﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    Construirmanager construirmanager;
   
    

    private void Start()
    {
        construirmanager = Construirmanager.instance;  //   scrit gracias a que es estatico
    }




    public void Comprarcañon()          // no se como explicar :|  /// aqui adcedemos al prefad seleccionado para porder adceder a el desde los botones 
    {
        if (construirmanager.monedas >= 150){
            construirmanager.Establecercañonparaconstruir(construirmanager.cañonprefab);
            construirmanager.monedas -= 150;
            if (construirmanager.monedas <= 149){
                
            }
            
                
            
        }
       
    }
    public void Comprarcañon2()
    {  
        if (construirmanager.monedas >= 250){
            construirmanager.Establecercañonparaconstruir(construirmanager.cañon2prefad);
            construirmanager.monedas -= 250;
        }
        
    }
    public void Comprarcaño3()
    {   
        if (construirmanager.monedas >=350){
            construirmanager.Establecercañonparaconstruir(construirmanager.cañon3prefad);
            construirmanager.monedas -= 350;
        }
        
    }
    
}
