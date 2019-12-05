using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    Construirmanager construirmanager;
    bool puedeconstruir = true;
   
    

    private void Start()
    {
        construirmanager = Construirmanager.instance;  //   scrit gracias a que es estatico
    }




    public void Comprarcañon()          // no se como explicar :|  /// aqui adcedemos al prefad seleccionado para porder adceder a el desde los botones 
    {   

            if (construirmanager.monedas >= 150 && construirmanager.canonselc == false)
            {
                construirmanager.Establecercañonparaconstruir(construirmanager.cañonprefab);
                construirmanager.monedas -= 150;
                construirmanager.Activarselec();
            
            
            }
            
            else if (construirmanager.monedas <= 149)
            {
                Debug.Log("NO TIENE SUFICIENTE ORO");
                
            }
 
    }
    public void Comprarcañon2()
    {  
        if (construirmanager.monedas >= 250 && construirmanager.canonselc == false){
            construirmanager.Establecercañonparaconstruir(construirmanager.cañon2prefad);
            construirmanager.monedas -= 250;
            construirmanager.Activarselec();
            
        }
        else if (construirmanager.monedas <= 259)
        {
            Debug.Log("NO TIENE SUFICIENTE ORO");

        }
        
    }
    public void Comprarcaño3()
    {   
        if (construirmanager.monedas >=350 && construirmanager.canonselc == false){
            construirmanager.Establecercañonparaconstruir(construirmanager.cañon3prefad);
            construirmanager.monedas -= 350;
            construirmanager.Activarselec();
           
        }
        else if (construirmanager.monedas <= 349)
        {
            Debug.Log("NO TIENE SUFICIENTE ORO");

        }
        
    }
    
}
