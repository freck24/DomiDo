using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gestormenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();  
    }
    public int sala;
    public int let;
    public string[] letras = { "a", "b", "c", "d" };
    public string salareal;
    // Update is called once per frame
    void Update()
    {
        
    }
    public Text salatext;
    public GameObject CREACIONDESALA;
    public GameObject jugarconamigos;

    public void jugaramigo()
    {
        jugarconamigos.SetActive(true);
    }
    public void CREARSALA()
    {
        creaciondesala();
        CREACIONDESALA.SetActive(true);
    }
    public void creaciondesala()
    {
        sala = Random.Range(1000, 9999);
        let = Random.Range(0, letras.Length);
        salareal = "" + letras[let] + sala;

        //Hay que comprobar si la sala existe y cambiar el codigo de sala
        salatext.text = "SALA: " + salareal;
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
}
