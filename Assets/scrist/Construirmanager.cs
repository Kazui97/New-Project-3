using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Construirmanager : MonoBehaviour
{
    public static Construirmanager instance;
    private GameObject cañonconstruido;
    public int monedas;
    public GameObject cañonprefab;
    public GameObject cañon2prefad;
    public GameObject cañon3prefad;
    public Text monedas_actules;
    public float tiempoMax = 180;
    public Text contadortiempo;
    public int tiempo;
    public bool canonselc = false;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("hay un erro :;v hay mas en la escena");
            return;
        }
        instance = this;
        monedas = 300;
    }
   
    void Update(){
        monedas_actules.text = "$ " + monedas;
        Reloj();
    }

    public void Reloj()
    {
        int minutos = 0;
        int segundo = 0;
        tiempoMax -= Time.deltaTime;
        minutos = (int)tiempoMax / 60;
        segundo = (int)tiempoMax % 60;
        contadortiempo.text = minutos.ToString("00") + ":" + segundo.ToString("00");
       // tiempo = (int)tiempoMax;
        //contadortiempo.text = tiempo.ToString();

        if (minutos == 0 && segundo == 0)
        {
            SceneManager.LoadScene("gane");
            Debug.Log("gg");
        }
    }

    public GameObject Conseguircañonparaconstruir()
    {
        return cañonconstruido;
    }

    public void Establecercañonparaconstruir(GameObject canon)
    {
        cañonconstruido = canon;
       
       
    }

    public void Activarselec()
    {
        canonselc = true;
    }
    public void Desactivarselec()
    {
        canonselc = false;
    }
   
    
}
