using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitar : MonoBehaviour
{
    // Start is called before the first frame update
    public bool cogido = false;

    public gestor G;
    Image yo;
    public int i = 0;
   
    void Start()
    {
        yo = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator quita()
    {
        yield return new WaitForSecondsRealtime(0.1f);

        if (G.activos[i])
        {
            if (G.miturno && G.QUITARLO)
            {
                gameObject.SetActive(false);
                //  G.turno();
            }
        }
    }

    public void q()
    {
        StartCoroutine(quita());
    }

    

}
