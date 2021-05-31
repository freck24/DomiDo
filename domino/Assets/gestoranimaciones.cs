using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestoranimaciones : MonoBehaviour
{
    // Start is called before the first frame update

    public gestor gestor;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void realizarjugada()
    { if(gestor.juegobloqueado==false)
        gestor.tirar();
        if (gestor.primerajugada)
        {
            gestor.primerajugada = false;
        }
        if (gestor.primeravez2)
        {
            gestor.primeravez2 = false;
        }


    }
    public void quitarficha()
    {
        gestor.quitarfichas();
        gestor.quitarfichastuyas();
    }
}
