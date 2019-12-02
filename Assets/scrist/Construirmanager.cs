using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Construirmanager : MonoBehaviour
{
    public static Construirmanager instance;
    private GameObject cañonconstruido;
    public int monedas;
    public GameObject cañonprefab;
    public GameObject cañon2prefad;
    public GameObject cañon3prefad;
    public Text monedas_actules;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("hay un erro :;v hay mas en la escena");
            return;
        }
        instance = this;
        monedas = 200;
    }
   
    void Update(){
        monedas_actules.text = "$ " + monedas;
       
    }


    public GameObject Conseguircañonparaconstruir()
    {
        return cañonconstruido;
    }

    public void Establecercañonparaconstruir(GameObject canon)
    {
        cañonconstruido = canon;
    }
   
    
}
