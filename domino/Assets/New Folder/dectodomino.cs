using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dectodomino : MonoBehaviour
{
    // Start is called before the first frame update

    public bool detectado = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "domino")
        {
            detectado = true;
        }
    }


}
