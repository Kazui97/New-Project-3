using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ajustes : MonoBehaviour
{
    public static ajustes intanceajuste;
   public bool activar;
    Canvas ajustespausa;

    void Start()
    {
        intanceajuste = this;
        ajustespausa = GetComponent<Canvas>();
        ajustespausa.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ajustesboton()
    {
        activar = !activar;
        ajustespausa.enabled = activar;
        Time.timeScale = (activar) ? 0 : 1f;
    }
}
