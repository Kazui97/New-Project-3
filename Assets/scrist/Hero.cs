using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Hero : MonoBehaviour
{
    public Image vida_hero;
    float vidamax = 100;
    float vidaactual;
    void Start()
    {
        vidaactual = vidamax;
    }

    void Vida()
    {
        vida_hero.fillAmount = (1 / vidamax) * vidaactual;
    }
    public void OnCollisionEnter(Collision col)
    {
       
        if (col.gameObject.GetComponent<EnemycontroleEsqueleto>())
        {
            vidaactual -= 50;
            if (vidaactual ==  0)
            {
                Invoke("Escenafinal",2f);
            }
            Vida();
        }
        if (col.gameObject.GetComponent<EnemyControleTrol>())
        {
            vidaactual -= 50;
             if (vidaactual ==  0)
            {
                Invoke("Escenafinal",2f);
            }
            Vida();
        }
        if (col.gameObject.GetComponent<ControladorGolem>())
        {
            vidaactual -= 50;
             if (vidaactual ==  0)
            {
                Invoke("Escenafinal",2f);
            }
            Vida();
        }

    }
    
    void Escenafinal()
    {
        SceneManager.LoadScene("perdi");
    }
   
    void Update()
    {
        
    }
}
