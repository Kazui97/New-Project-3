using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construirmanager : MonoBehaviour
{
    public static Construirmanager instance;
    private GameObject cañonconstruido;
    public GameObject cañonprefab;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("hay un erro :;v hay mas en la escena");
            return;
        }
        instance = this;
    }
    void Start()
    {
        cañonconstruido = cañonprefab;
    }
    public GameObject cañonparaconstruir()
    {
        return cañonconstruido;
    }
   
    void Update()
    {
        
    }
}
