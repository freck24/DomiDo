using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestoranimaciones : MonoBehaviour
{
    // Start is called before the first frame update

    public gestor gestor;
    public Vector3 pos;
    public Transform yo;
    

    void Start()
    {
        pos = yo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void volvermiposicion()
    {
        yo.transform.position = pos;
    }


    public void realizarjugada()
    { if(gestor.juegobloqueado==false)
       gestor.PrendeFichas();


        if (gestor.primerajugada)
        {
            gestor.primerajugada = false;
        }
        if (gestor.primeravez2)
        {
            gestor.primeravez2 = false;
        }
      // gestor.turnando();
        gestor.contand();


    }
    public void quitarficha()
    {
        gestor.quitarfichas();
        gestor.quitarfichastuyas();
    }
}
