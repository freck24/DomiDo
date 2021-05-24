using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieza : MonoBehaviour
{
    // Start is called before the first frame update

   public int i;
   public int j;
    public Transform arriba;
    public Transform abajo;
    public Transform derecha;
    public Transform izquierda;
    public gestor g;


    public bool arribab;
    public bool abajob;
    public bool derechab;
    public bool izquierdab;
    public bool doble;
    public Transform domino;



    void Start()
    {
        if (i == j)
        {
            doble = true;
          //  transform.eulerAngles = new Vector3(90, 90, 0);

        }
        if (doble)
        {
            izquierdab = true;
            derechab = true;
        }
        else
        {
            arribab = true;
            abajob = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
