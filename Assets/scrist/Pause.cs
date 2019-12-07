using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool active;
    bool activarsonidos;
    Canvas Canvas;
    public Image sonido;
    public Image ok;
    public Button sonidoact;
    public Image calse;
    public Button sonidodesc;

    void Start()
    {
        Canvas = GetComponent<Canvas>();
        Canvas.enabled = false;
        sonido.enabled = false;
        ok.enabled = false;
        sonidoact.enabled = false;
        calse.enabled = false;
        sonidodesc.enabled = false;
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausaprueba();
        }
    }
    public void Pausaprueba()
    {


        active = !active;
        Canvas.enabled = active;
        Time.timeScale = (active) ? 0 : 1f;


    }

    public void Sonidos()
    {
        activarsonidos = !activarsonidos;
        sonido.enabled =activarsonidos;
        ok.enabled = activarsonidos;
        sonidoact.enabled = activarsonidos;
        calse.enabled = activarsonidos;
        sonidodesc.enabled = activarsonidos;


    }
}
