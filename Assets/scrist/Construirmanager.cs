using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construirmanager : MonoBehaviour
{
    public static Construirmanager instance;
    private GameObject cañonconstruido;
    public GameObject cañonprefab;
    public GameObject cañon2prefad;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("hay un erro :;v hay mas en la escena");
            return;
        }
        instance = this;
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
