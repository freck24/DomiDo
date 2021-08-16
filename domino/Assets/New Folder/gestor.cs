using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gestor : MonoBehaviour
{
    public GameObject controlesprincipal;
    // Start is called before the first frame update
    public int[] jugadas=new int[28];
    public int numerodejugadas = 0;

    

   

    public bool automatico1 = false;
    public bool automatico2 = false;
    public bool automatico3 = false;
    public bool automatico4 = false;

    public void brutezaartificial1()
    {
        if (primerajugada)
        {
            i = 27;
            jugadademas();
            button[27].SetActive(false);

        }
        else
        {



            int k = 0;
            while (button[j1[k]].activeSelf == false && k < 7 || activos[j1[k]] == false && k < 7)
            {

                k++;

            }

            i = j1[k];

            button[j1[k]].SetActive(false);


            if (codigos[i].i == n1 || codigos[i].j == n1)
            {

                if (turn == 1)

                    izq();

            }
            else if (codigos[i].j == n2 || codigos[i].i == n2)
            {

                if (turn == 1)
                    der();

            }
        }
    }

    public void brutezaartificial2()
    {

        if (primerajugada)
        {
            i = 27;
            jugadademas();
            BUTTON2[27].SetActive(false);

        }
        else
        {







            int k = 0;
            while (BUTTON2[j2[k]].activeSelf == false && k < 7 || activos[j2[k]] == false && k < 7)
            {

                k++;

            }

            i = j2[k];

            BUTTON2[j2[k]].SetActive(false);


            if (codigos[i].i == n1 || codigos[i].j == n1)
            {

                if (turn == 2)

                    izq();

            }
            else if (codigos[i].j == n2 || codigos[i].i == n2)
            {

                if (turn == 2)
                    der();

            }
        }

    }



    public void brutezaartificial3()
    {

        if (primerajugada)
        {
            i = 27;
            jugadademas();
            BUTTON3[27].SetActive(false);

        }
        else
        {


            int k = 0;
            while (BUTTON3[j3[k]].activeSelf == false && k < 7 || activos[j3[k]] == false && k < 7)
            {

                k++;

            }

            i = j3[k];
            //  print("es el" + i);
            BUTTON3[j3[k]].SetActive(false);

            if (codigos[i].i == n1 || codigos[i].j == n1)
            {

                if (turn == 3)
                    izq();

            }
            else if (codigos[i].j == n2 || codigos[i].i == n2)
            {

                if (turn == 3)
                    der();

            }


        }

    }

    public void brutezaartificial4()
    {

        if (primerajugada)
        {
            i = 27;
            jugadademas();
            BUTTON4[27].SetActive(false);

        }
        else
        {



            int k = 0;
            while (BUTTON4[j4[k]].activeSelf == false && k < 7 || activos[j4[k]] == false && k < 7)
            {

                k++;

            }

            i = j4[k];
            //    print("es el" + i);
            BUTTON4[j4[k]].SetActive(false);


            if (codigos[i].j == n2 || codigos[i].i == n2)
            {

                if (turn == 4)
                    //    print("jugo derechA");
                    der();

            }
            else
           if (codigos[i].i == n1 || codigos[i].j == n1)
            {

                if (turn == 4)
                    //         print("jugo IZQUIERDA");
                    izq();

            }

        }


    }





  
    public int turn = 1;
    public int JUGADOR = 1;
    public bool derecha;
    public pieza p1;
    public pieza p2;
    public int n1;
    public int n2;

    public pieza[] codigos;
    public Transform centro;
    public Transform[] pieza;
    public GameObject[] dominos;
    public int i;
    public bool primerajugada = true;

    public bool miturno = true;
    public int[] j1 = new int[7];
    public int[] j2 = new int[7];
    public int[] j3 = new int[7];
    public int[] j4 = new int[7];
    public int[] j2i = new int[7];
    public int[] j2j = new int[7];


    public int cantidadfichas1 = 7;
    public int cantidadfichas2 = 7;
    public int cantidadfichas3 = 7;
    public int cantidadfichas4 = 7;
    public GameObject[] MENSAJEGANAR;

    public GameObject[] fj1;
    public GameObject[] fj2;
    public GameObject[] fj3;
    public GameObject[] fj4;

    public Transform[] tufichas;
    public void quitarfichas()
    {
        contar1();
        /* for(int k=0;k<(7-cantidadfichas1); k++)
         {
             fj1[k].SetActive(false);
         }*/

        for (int k = 0; k < (7 - cantidadfichas2); k++)
        {
            fj2[k].SetActive(false);
        } for (int k = 0; k < (7 - cantidadfichas3); k++)
        {
            fj3[k].SetActive(false);
        } for (int k = 0; k < (7 - cantidadfichas4); k++)
        {
            fj4[k].SetActive(false);
        }
    }




    public void contar1()
    {
        cantidadfichas1 = 0;
        cantidadfichas2 = 0;
        cantidadfichas3 = 0;
        cantidadfichas4 = 0;

        for (int k = 0; k < button.Length; k++)
        { if (button[k].activeSelf)
                cantidadfichas1 += 1;


            if (BUTTON2[k].activeSelf)
                cantidadfichas2 += 1;

            if (BUTTON3[k].activeSelf)
                cantidadfichas3 += 1;

            if (BUTTON4[k].activeSelf)
                cantidadfichas4 += 1;

        }

        if (cantidadfichas1 == 0)
        {
            StopAllCoroutines();
            StartCoroutine(nuevojuego());

            if (JUGADOR == 1)
            {
                MENSAJEGANAR[0].SetActive(true);
            }
            else
            {
                MENSAJEGANAR[1].SetActive(true);
            }

        } if (cantidadfichas2 == 0)
        {
            StopAllCoroutines();
            StartCoroutine(nuevojuego());

            if (JUGADOR == 2)
            {
                MENSAJEGANAR[0].SetActive(true);
            }
            else
            {
                MENSAJEGANAR[1].SetActive(true);
            }
        } if (cantidadfichas3 == 0)
        {
            StopAllCoroutines();
            StartCoroutine(nuevojuego());
            if (JUGADOR == 3)
            {
                MENSAJEGANAR[0].SetActive(true);
            }
            else
            {
                MENSAJEGANAR[1].SetActive(true);
            }
        } if (cantidadfichas4 == 0)
        {
            StopAllCoroutines();
            StartCoroutine(nuevojuego());
            if (JUGADOR == 4)
            {
                MENSAJEGANAR[0].SetActive(true);
            }
            else
            {
                MENSAJEGANAR[1].SetActive(true);
            }
        }



        // quitarfichas();

    }
    public int puntuacionnivel;
    public int puntuacionnivel1;
    public int puntuacionnivel2;
    public int puntuacionnivel3;
    public int puntuacionnivel4;
    public void actualizarpuntuacion()
    {
        for (int k = 0; k < button.Length; k++)
        {
            if (button[k].activeSelf)
            {
                puntuacionnivel1 += codigos[k].i;
                puntuacionnivel1 += codigos[k].j;
            }

            if (BUTTON2[k].activeSelf)
            {
                puntuacionnivel2 += codigos[k].i;
                puntuacionnivel2 += codigos[k].j;
            }

            if (BUTTON3[k].activeSelf)
            {
                puntuacionnivel3 += codigos[k].i;
                puntuacionnivel3 += codigos[k].j;
            }


            if (BUTTON4[k].activeSelf)
            {
                puntuacionnivel4 += codigos[k].i;
                puntuacionnivel4 += codigos[k].j;
            }




        }
        puntuacionnivel = puntuacionnivel1 + puntuacionnivel2 + puntuacionnivel3 + puntuacionnivel4;


        if (cantidadfichas1 == 0)
        {
            puntj1 += puntuacionnivel;
        } if (cantidadfichas2 == 0)
        {
            puntj2 += puntuacionnivel;
        } if (cantidadfichas3 == 0)
        {
            puntj3 += puntuacionnivel;
        } if (cantidadfichas4 == 0)
        {
            puntj4 += puntuacionnivel;
        }

        PlayerPrefs.SetInt("puntj1", puntj1);
        PlayerPrefs.SetInt("puntj2", puntj2);
        PlayerPrefs.SetInt("puntj3", puntj3);
        PlayerPrefs.SetInt("puntj4", puntj4);

    }

    public Text mensaje;
    public GameObject mensajeCAMBIARBLE;

    IEnumerator nuevojuego()
    {
        actualizarpuntuacion();

        yield return new WaitForSecondsRealtime(2);
        if (juegobloqueado)
        {
            if (puntuacionnivel1 < puntuacionnivel2 && puntuacionnivel1 < puntuacionnivel3 && puntuacionnivel1 < puntuacionnivel4)
            {
                mensaje.text = "GANO EL PRIMER JUGADOR";
                mensajeCAMBIARBLE.SetActive(false);
                mensajeCAMBIARBLE.SetActive(true);
                puntj1 += puntuacionnivel;
                PlayerPrefs.SetInt("puntj1", puntj1);
            }
            else if (puntuacionnivel2 < puntuacionnivel1 && puntuacionnivel2 < puntuacionnivel3 && puntuacionnivel2 < puntuacionnivel4)
            {
                mensaje.text = "GANO EL SEGUNDO JUGADOR";
                mensajeCAMBIARBLE.SetActive(false);
                mensajeCAMBIARBLE.SetActive(true);
                puntj2 += puntuacionnivel;
                PlayerPrefs.SetInt("puntj2", puntj2);
            }
            else if (puntuacionnivel3 < puntuacionnivel2 && puntuacionnivel3 < puntuacionnivel1 && puntuacionnivel3 < puntuacionnivel4)
            {
                mensaje.text = "GANO EL TERCER JUGADOR";
                mensajeCAMBIARBLE.SetActive(false);
                mensajeCAMBIARBLE.SetActive(true);
                puntj3 += puntuacionnivel;
                PlayerPrefs.SetInt("puntj3", puntj3);
            }
            else if (puntuacionnivel4 < puntuacionnivel2 && puntuacionnivel4 < puntuacionnivel3 && puntuacionnivel4 < puntuacionnivel1)
            {
                mensaje.text = "GANO EL CUARTO JUGADOR";
                mensajeCAMBIARBLE.SetActive(false);
                mensajeCAMBIARBLE.SetActive(true);
                puntj4 += puntuacionnivel;
                PlayerPrefs.SetInt("puntj4", puntj4);
            }
            else
            {
                mensaje.text = "NO HUBO GANADOR";
                mensajeCAMBIARBLE.SetActive(false);
                mensajeCAMBIARBLE.SetActive(true);

            }
        }

        //  SceneManager.LoadScene(0);
    }
    public int[] ordenado = new int[7];
    public int mayor;

    public int valorguardado;
    public int valorguardadomayor;

    public bool[] jugo = new bool[4];
    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void ordenar()
    {






        for (int k = 0; k < j1.Length; k++)
        {
            mayor = j1[k];


            valorguardadomayor = -1;

            for (int h = 6; h > k; h--)
            {
                if (j1[h] > mayor)
                {
                    mayor = j1[h];
                    valorguardadomayor = h;
                }


            }

            if (valorguardadomayor == -1)
            {
                valorguardadomayor = k;
            }

            valorguardado = j1[k];
            j1[k] = mayor;
            j1[valorguardadomayor] = valorguardado;

        }

    }


    public quitar[] cogen;
    public void fichas()
    {
        {
            for (int k = 0; k < 7; k++)
            {
                j1[k] = Random.Range(0, 28);
                while (cogen[j1[k]].cogido)
                {
                    j1[k] = Random.Range(0, 28);
                }
                if (j1[k] == 27)
                {
                    turn = 1;
                    //  print("klk");
                }
                cogen[j1[k]].cogido = true;

            }
            ordenar();

            for (int k = 0; k < 7; k++)
            {
                tufichas[j1[k]].position = fj1[6 - k].transform.position;
                tufichas[j1[k]].eulerAngles = fj1[6 - k].transform.eulerAngles;

            }



            for (int k = 0; k < 7; k++)
            {
                j2[k] = Random.Range(0, 28);

                j2i[k] = codigos[j2[k]].i; //hacerlo con los demas
                j2j[k] = codigos[j2[k]].j;

                while (cogen[j2[k]].cogido)
                {
                    j2[k] = Random.Range(0, 28);
                }

                if (j2[k] == 27)
                {
                    turn = 2;
                    //   print("klk");
                }

                cogen[j2[k]].cogido = true;
            } for (int k = 0; k < 7; k++)
            {
                j3[k] = Random.Range(0, 28);
                while (cogen[j3[k]].cogido)
                {
                    j3[k] = Random.Range(0, 28);
                }
                if (j3[k] == 27)
                {
                    turn = 3;
                    //  print("klk");
                }
                cogen[j3[k]].cogido = true;
            }

            for (int k = 0; k < 7; k++)
            {
                j4[k] = Random.Range(0, 28);
                while (cogen[j4[k]].cogido)
                {
                    j4[k] = Random.Range(0, 28);
                }
                if (j4[k] == 27)
                {
                    turn = 4;
                    //  print("klk");
                }
                cogen[j4[k]].cogido = true;
            }


            turnotext.text = "JUGADOR " + turn;
            if (turn == JUGADOR)
            {
                BLOQUEADOR.SetActive(false);
            }
            else { BLOQUEADOR.SetActive(true); }
        }

    }



    public void BA2()
    { int k = 0;
        while (k < 7 && (codigos[j2[k]].i != n1 || codigos[j2[k]].j != n1 || codigos[j2[k]].i != n2 || codigos[j2[k]].j != n2))
        {
            i = j2[k];
            if (i == n1)
            {
                der();
            }
            else if (i == n2)
            {
                izq();
            }

            k++;
        }
    }

    public GameObject[] BUTTON2;
    public GameObject[] BUTTON3;
    public GameObject[] BUTTON4;
    public GameObject[] button;
    public void alea()
    {
        fichas();
        for (int r = 0; r < 7; r++)
        {
            button[j1[r]].SetActive(true);
            BUTTON2[j2[r]].SetActive(true);
            BUTTON3[j3[r]].SetActive(true);
            BUTTON4[j4[r]].SetActive(true);


        }
    }

    public void turno()
    {
        miturno = false;
    }
    public Text puntj1text;
    public Text puntj2text;
    public Text puntj3text;
    public Text puntj4text;
    void Start()
    {
        numerodejugadas = 0;
        for(int k = 0; k < TIEMPO.Length; k++)
        {
            TIEMPO[k] = tiempoglabal;
            if (automaticotiempo[k])
            {
                TIEMPO[k] = tiempoautomatico;
            }
            else
            {
                TIEMPO[k] = tiempoglabal;
            }

        }



        camara();
        puntj1 = PlayerPrefs.GetInt("puntj1", 0);
        puntj2 = PlayerPrefs.GetInt("puntj2", 0);
        puntj3 = PlayerPrefs.GetInt("puntj3", 0);
        puntj4 = PlayerPrefs.GetInt("puntj4", 0);
        puntj1text.text = puntj1.ToString();
        puntj2text.text = puntj2.ToString();
        puntj3text.text = puntj3.ToString();
        puntj4text.text = puntj4.ToString();

        alea();
        for (int k = 0; k < ordenado.Length; k++)
        {
            ordenado[k] = j1[k];
        }


        turnotext.text = "JUGADOR " + turn;


        StartCoroutine(contando());
       

        if (turn != JUGADOR)
        {

            for (int k = 0; k < codigos.Length; k++)
            {

                botones[k].color = d;
            }
        }

    }

    public Animator[] mano1;
    public Transform[] mano1transform;


    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;
    public void quitadordeprimerosbotones()
    {
        BLOQUEADOR.SetActive(true);
        for (int k = 0; k < codigos.Length; k++)
        {

            botones[k].color = d;

        }
    }


    public void jugadademas()
    {
        //  print("jugue");

        if (turn == 1)
        {

            quitadordeprimerosbotones();
            animator1.SetBool("jugar", true);
            print("jugueyo");
        }
        if (turn == 2)
        {

            animator2.SetBool("jugar", true);
            print("jugueyo");
        }
        if (turn == 3)
        {

            animator3.SetBool("jugar", true);
            print("jugueyo");
        }
        if (turn == 4)
        {

            animator4.SetBool("jugar", true);
            print("jugueyo");
        }
        tirar();


        mano1transform[turn - 1].transform.position = fichasobjetos[i].position;
    }

    public void der()
    {
        derecha = true;
        if (cantidadfichas1 != 0 && cantidadfichas2 != 0 && cantidadfichas3 != 0 && cantidadfichas4 != 0)
        {
            if (turn == 1)
            {

                quitadordeprimerosbotones();
                animator1.SetBool("jugar", true);
            }
            if (turn == 2)
            {

                animator2.SetBool("jugar", true);
            }
            if (turn == 3)
            {

                animator3.SetBool("jugar", true);
            }
            if (turn == 4)
            {

                animator4.SetBool("jugar", true);
            }
            ladoizquierdo.SetActive(false);
            ladoderecho.SetActive(false);

            tirar();
            mano1transform[turn - 1].transform.position = fichasobjetos[i].position;
        }
    }

    public void falseador()
    {
        if (turn == 1)
        {
            animator1.SetBool("jugar", false);
        }
        if (turn == 2)
        {
            animator2.SetBool("jugar", false);
        }
        if (turn == 3)
        {
            animator3.SetBool("jugar", false);
        }
        if (turn == 4)
        {
            animator4.SetBool("jugar", false);
        }
    }
    public GameObject[] fichasrenderer;

    public void PrendeFichas()
    {
        fichasrenderer[i].SetActive(true);
        a.PlayOneShot(dominofuerte);

        for (int k = 0; k < 4; k++)
        {
            jugo[k] = false;
           // if (k != (turn - 1))
            {
                barratiempo[k].transform.localScale = new Vector3(0, 1, 1);
            }
        }
    }



    public AudioSource a;
    public AudioClip dominofuerte;
    public void izq()
    {
        derecha = false;
        if (cantidadfichas1 != 0 && cantidadfichas2 != 0 && cantidadfichas3 != 0 && cantidadfichas4 != 0)
        {
            if (turn == 1)
            {

                quitadordeprimerosbotones();
                animator1.SetBool("jugar", true);
            }
            if (turn == 2)
            {

                animator2.SetBool("jugar", true);
            }
            if (turn == 3)
            {

                animator3.SetBool("jugar", true);
            }
            if (turn == 4)
            {

                animator4.SetBool("jugar", true);
            }
            ladoizquierdo.SetActive(false);
            ladoderecho.SetActive(false);
            tirar();
            mano1transform[turn - 1].transform.position = fichasobjetos[i].position;
        }
    }
    #region


    public bool QUITARLO = false;

    public GameObject ladoderecho;
    public GameObject ladoizquierdo;
    public bool primeravez2 = true;

    public bool lado1 = false;
    public bool lado2 = false;
    public void LadoTablero()
    {
        if (primeravez2 == false)
        {


            ladoizquierdo.SetActive(false);
            ladoderecho.SetActive(false);
            lado1 = false;
            lado2 = false;

            if (codigos[i].i == n1 || codigos[i].j == n1)
            {
                ladoizquierdo.SetActive(true);
                lado1 = true;
            }
            if (codigos[i].i == n2 || codigos[i].j == n2)
            {
                ladoderecho.SetActive(true);
                lado2 = true;
            }

            if (lado1 == true && lado2 == false)
            {
                izq();
            }
            if (lado1 == false && lado2 == true)
            {
                der();
            }

        }

        primeravez2 = false;
    }


    public void b0()
    {
        i = 0;

        if (primerajugada)
        {
            jugadademas();
        }

        LadoTablero();
    } public void b1()
    {
        i = 1;
        if (primerajugada)
        {
            jugadademas();
        }


        LadoTablero();
    } public void b2()
    {
        i = 2;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b3()
    {
        i = 3;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b4()
    {
        i = 4;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b5()
    {
        i = 5;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b6()
    {
        i = 6;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b7()
    {
        i = 7;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b8()
    {
        i = 8;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b9()
    {
        i = 9;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b10()
    {
        i = 10;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b11()
    {
        i = 11;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b12()
    {
        i = 12;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b13()
    {
        i = 13;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b14()
    {
        i = 14;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b15()
    {
        i = 15;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b16()
    {
        i = 16;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b17()
    {
        i = 17;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b18()
    {
        i = 18;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b19()
    {
        i = 19;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    } public void b20()
    {
        i = 20;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }
    public void b21()
    {
        i = 21;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }
    public void b22()
    {
        i = 22;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }
    public void b23()
    {
        i = 23;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }
    public void b24()
    {
        i = 24;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }
    public void b25()
    {
        i = 25;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }
    public void b26()
    {
        i = 26;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }
    public void b27()
    {
        i = 27;
        if (primerajugada)
        {
            jugadademas(); ;
        }
        LadoTablero();
    }


    #endregion


    public Transform[] fichasobjetos;

    public dectodomino detecto1;
    public dectodomino detecto2;
    public dectodomino detecto3;
    public dectodomino detecto4;
    public bool unavezdec1 = true;
    public bool unavezdec2 = true;

    public bool doblederecha = false;
    public bool dobleizquierda = false;


    public bool[] rotaciones = new bool[5];
    public bool[] rotaciones2 = new bool[5];

    public void logica()
    {




        {
            if (derecha)
            {

                if (codigos[i].doble == false)

                {


                    /*   if (doblarderecha)
                       {
                           for (int k = 0; k < rotaciones2.Length; k++)
                           {
                               rotaciones2[k] = false;
                           }
                           unavezdec2 = true;
                       }*/


                    if (detecto2.detectado == true && unavezdec2 && doblederecha == false)
                    {
                        doblarderecha = true;
                        unavezdec2 = false;


                    }


                    if (detecto3.detectado && unavezdec2)
                    {
                        doblarderecha = true;

                        unavezdec2 = false;

                    }


                    if (doblarderecha)
                    {
                        pieza[i].position = new Vector3(p1.arriba.position.x + 1.1f, p1.arriba.position.y, p1.arriba.position.z - 1.06f);
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);

                        doblarderecha = false;
                        rotaciones2[0] = true;
                    }
                    else
                         if (rotaciones2[0])
                    {

                        pieza[i].position = p1.arriba.position;
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);
                        rotaciones2[0] = false;
                        rotaciones2[1] = true;
                    }
                    else if (rotaciones2[1])
                    {

                        pieza[i].position = new Vector3(p1.arriba.position.x - 1.1f, p1.arriba.position.y, p1.arriba.position.z - 1.1f);
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -180);
                        rotaciones2[1] = false;
                        rotaciones2[2] = true;



                    }
                    else if (rotaciones2[2])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -180);
                        pieza[i].position = p1.arriba.position;

                    }
                    else
                    {
                        pieza[i].position = p1.arriba.position;
                    }
                    p1 = codigos[i];




                    doblederecha = false;

                }
                else
                {




                    if (rotaciones2[0])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);

                    }
                    if (rotaciones2[1])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);

                        rotaciones2[0] = true;
                        rotaciones2[1] = false;


                    }

                    if (rotaciones2[2])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -180);
                    }







                    doblederecha = true;



                    pieza[i].position = p1.derecha.position;
                    p1 = codigos[i];
                    n2 = p1.j;

                }




            }
            else
            {


                if (codigos[i].doble == false)



                {


                    if (detecto1.detectado == true && unavezdec1 && dobleizquierda == false)
                    {
                        doblarizquierda = true;
                        unavezdec1 = false;
                    }


                    if (detecto4.detectado && unavezdec1)
                    {
                        dobleizquierda = true;

                        unavezdec1 = false;

                    }

                    if (doblarizquierda)
                    {
                        pieza[i].position = new Vector3(p2.abajo.position.x - 1.1f, p2.abajo.position.y, p2.abajo.position.z + 1.06f);
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);

                        doblarizquierda = false;
                        rotaciones[0] = true;
                    }
                    else
                         if (rotaciones[0])
                    {

                        pieza[i].position = p2.abajo.position;
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);
                        rotaciones[0] = false;
                        rotaciones[1] = true;
                    }
                    else if (rotaciones[1])
                    {

                        pieza[i].position = new Vector3(p2.abajo.position.x + 1f, p2.abajo.position.y, p2.abajo.position.z + 1);
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -180);
                        rotaciones[1] = false;
                        rotaciones[2] = true;



                    }
                    else if (rotaciones[2])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -180);
                        pieza[i].position = p2.abajo.position;

                    }


                    else
                    {
                        pieza[i].position = p2.abajo.position;

                    }

                    p2 = codigos[i];


                    dobleizquierda = false;

                }
                else
                {
                    if (rotaciones[0])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);
                        print("ocurre");
                    } if (rotaciones[1])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -90);
                        print("ocurre");
                        rotaciones[0] = true;
                        rotaciones[1] = false;


                    }

                    if (rotaciones[2])
                    {
                        fichasobjetos[i].eulerAngles = new Vector3(90, 0, -180);
                    }

                    pieza[i].position = p2.izquierda.position;
                    p2 = codigos[i];
                    n1 = p2.j;

                    dobleizquierda = true;
                }

            }



        }

    }

    public GameObject Novalido;
    public GameObject[] nova;

    public void mensaje1()
    {
        Novalido.SetActive(false);
        Novalido.SetActive(true);
    }
    public bool[] activos = new bool[28];
    public Image[] botones = new Image[28];
    public Image[] botones2 = new Image[28];
    public Image[] botones3 = new Image[28];
    public Image[] botones4 = new Image[28];
    public Color c;
    public Color d;
    public Color white;

    public GameObject cam1;
    public GameObject cam2;
    public bool cama = false;

    public int puntj1;
    public int puntj2;
    public int puntj3;
    public int puntj4;


    public void newgame()
    {
        SceneManager.LoadScene(1);
    }

    public Animator[] avatar1animator;
    public void cambiaranimator()
    {
        if (cama)
        {
            animator1 = mano1[0];
            animator2 = mano1[1];
            animator3 = mano1[2];
            animator4 = mano1[3];
        }
        else
        {
            animator1 = avatar1animator[0];
            animator2 = avatar1animator[1];
            animator3 = avatar1animator[2];
            animator4 = avatar1animator[3];
        }


    }
    public GameObject manitas;//aqui convertir en arreglo cuando haya mas persoANJES
    public GameObject avatar; // aqui convertir en arreglo cuando haya mas persoANJES
    public void camara()
    {
        cam1.SetActive(cama);
        cam2.SetActive(!cama);
        cambiaranimator();

        if (cama)
        {
            avatar.SetActive(false);
            manitas.SetActive(true);



        }
        else
        {
            avatar.SetActive(true);
            manitas.SetActive(false);
        }
        cama = !cama;


    }

    public void comprobar()
    {
        for (int k = 0; k < codigos.Length; k++)
        {
            activos[k] = false;
            botones[k].color = c;
            // botones2[k].color = c;
            //  botones3[k].color = c;
            //  botones4[k].color = c;
            if (codigos[k].j == n1 || codigos[k].i == n1 || codigos[k].i == n2 || codigos[k].j == n2)
            {

                activos[k] = true;



                botones[k].color = white;

                //     botones2[k].color = Color.white;
                //      botones3[k].color = Color.white;
                //      botones4[k].color = Color.white;
            }
        }

    }
    public Text turnotext;
    public GameObject BLOQUEADOR;
    public bool novbool = false;
    public bool va = true;
    public bool juegobloqueado = false;

    public bool[] j1ver = new bool[7];

    public GameObject mensajebloqueo;
    public void Comprobadordeturno()
    {

        juegobloqueado = true;
        for (int k = 0; k < activos.Length; k++)
        {

            if (activos[k] && button[k].activeSelf || activos[k] && BUTTON2[k].activeSelf || activos[k] && BUTTON3[k].activeSelf || activos[k] && BUTTON4[k].activeSelf)
            {
                juegobloqueado = false;
                // print("klk2");
            }
        }



        if (juegobloqueado == false)
        {


            if (turn == 1 && JUGADOR == 1)
            {
                novbool = true;
                for (int k = 0; k < 7; k++)
                {

                    if (activos[j1[k]] == true && button[j1[k]].activeSelf)
                    {
                        novbool = false;
                        va = true;
                    }
                }

                if (novbool)
                {
                    Novalido.SetActive(false);
                    Novalido.SetActive(true);
                    turnando();
                    va = false;
                }

                novbool = false;
            }


            if (turn == 2)
            {
                novbool = true;
                for (int k = 0; k < 7; k++)
                {
                    if (activos[j2[k]] == true && BUTTON2[j2[k]].activeSelf)
                    {
                        novbool = false;
                        va = true;
                    }
                }

                if (novbool)
                {
                    nova[0].SetActive(false);
                    nova[0].SetActive(true);
                    turnando();
                    va = false;
                }

                novbool = false;
            }


            if (turn == 3)
            {
                novbool = true;
                for (int k = 0; k < 7; k++)
                {
                    if (activos[j3[k]] == true && BUTTON3[j3[k]].activeSelf)
                    {
                        novbool = false;
                        va = true;
                    }
                }

                if (novbool)
                {
                    nova[1].SetActive(false);
                    nova[1].SetActive(true);
                    turnando();
                    va = false;
                }

                novbool = false;
            }


            if (turn == 4)
            {
                novbool = true;
                for (int k = 0; k < 7; k++)
                {
                    if (activos[j4[k]] == true && BUTTON4[j4[k]].activeSelf)
                    {
                        novbool = false;
                        va = true;
                    }
                }

                if (novbool)
                {
                    nova[2].SetActive(false);
                    nova[2].SetActive(true);
                    turnando();
                    va = false;
                }

                novbool = false;
            }
        }
        else
        {
            mensajebloqueo.SetActive(true);
            StopAllCoroutines();
            StartCoroutine(nuevojuego());
        }

    }




    public void yajugue()
    {
        jugo[turn - 1] = true;
        TIEMPO[turn - 1] = 0;
    }


    public void turnando()
    { for(int k =0; k<4; k++)
        {
            jugo[k] = false;
            if (k!= (turn-1))
            {
                barratiempo[k].transform.localScale = new Vector3(0, 1, 1);
            }
        }
        if (turn < 4)
        {
            turn += 1;
        }
        else
        {
            turn = 1;
        }

        if (turn == JUGADOR)
        {
            BLOQUEADOR.SetActive(false);
        }
        else { BLOQUEADOR.SetActive(true); }


        turnotext.text = "JUGADOR " + turn;

    }
    public bool doblarizquierda = false;
    public bool doblarderecha = false;

    public void quitarfichastuyas()
    {
        tusfi[i].SetActive(false);
    }

    public int[] derechaslista = new int[28];
    public void tirar()
    {
        //  falseador();
        // turnando();
        jugadas[numerodejugadas] = i;
        if (derecha)
        {
            derechaslista[numerodejugadas] = 1;
        }
        numerodejugadas +=1;
       

        if (primerajugada)
        {
            p1 = codigos[i];
            p2 = codigos[i];
            pieza[i].position = centro.position;

            primerajugada = false;
            n1 = p1.i;
            n2 = p1.j;
        }
        else
        {
            if (derecha)
            {

                if (codigos[i].i == n2)
                {
                    logica();
                    n2 = codigos[i].j;
                    QUITARLO = true;
                }
                else if (codigos[i].j == n2)
                {
                    codigos[i].domino.eulerAngles = new Vector3(-90, 0, 0);
                    logica();
                    n2 = codigos[i].i;
                    QUITARLO = true;

                }
                else
                {
                    mensaje1();
                }


            }
            else
            {
                if (codigos[i].j == n1)
                {


                    logica();
                    n1 = codigos[i].i;
                    QUITARLO = true;

                }
                else
                  if (codigos[i].i == n1)
                {
                    codigos[i].domino.eulerAngles = new Vector3(-90, 0, 0);
                    logica();
                    n1 = codigos[i].j;
                    QUITARLO = true;

                }
                else
                {
                    mensaje1();
                }
            }

        }



        comprobar();





        if (va == false)
        {
            falseador();
        }



        if (turn != JUGADOR)
        {

            for (int k = 0; k < codigos.Length; k++)
            {

                botones[k].color = d;

            }
        }


        //  StartCoroutine(contando());



       
    }



    public void contand()
    {
        StopCoroutine(contando());
        StartCoroutine(contando());




        turnando();


        va = false; // no se
        while (va == false && juegobloqueado == false)
            Comprobadordeturno();


        if (turn != JUGADOR)
        {

            for (int k = 0; k < codigos.Length; k++)
            {

                botones[k].color = d;

            }
        }
        else
        {
            comprobar();

        }

        falseador();

    }


    public GameObject[] tusfi;
    public bool jugar = true;
    IEnumerator contando()
    {
        falseador();
        yield return new WaitForSecondsRealtime(0.1f);

       

        contar1();
        puedebajar = true;

        /* if (juegobloqueado == false) {


             yield return new WaitForSecondsRealtime(1.5f);

             if (turn == 2)
             {

                 if (primerajugada)
                 {
                     i = 27;
                     jugadademas();
                     BUTTON2[27].SetActive(false);

                 }
                 else
                 {
                     brutezaartificial2();
                 }

             }

             yield return new WaitForSecondsRealtime(1.5f);

             if (turn == 3)
             {

                 if (primerajugada)
                 {
                     i = 27;
                     jugadademas();
                     BUTTON3[27].SetActive(false);

                 }
                 else
                 {
                     brutezaartificial3();
                 }

             }

             yield return new WaitForSecondsRealtime(1.5f);


             if (turn == 4)
             {

                 if (primerajugada)
                 {
                     i = 27;
                     jugadademas();
                     BUTTON4[27].SetActive(false);

                 }
                 else
                 {
                     brutezaartificial4();
                 }

             }








         }*/

    }

    // Update is called once per frame

    public bool[] automaticotiempo = new bool[4];
    public float tiempoglabal;
    public float tiempoautomatico;
    public float[] TIEMPO=new float[4];
    public Transform[] barratiempo;
    int guardaturn;
    public Toggle automaticotoggle;
   public bool puedebajar = true; // iniciar cuando yo quiera

    void Update()
    {


        if (turn != guardaturn)
        {
            puedebajar = true;
        }

        if (puedebajar)
        {
            if (TIEMPO[turn - 1] > 0)
            {
                TIEMPO[turn - 1] -= Time.deltaTime;
                if (automaticotiempo[turn - 1])
                {
                   
                    barratiempo[turn - 1].transform.localScale = new Vector3(TIEMPO[turn - 1] / tiempoautomatico, barratiempo[turn - 1].transform.localScale.y, barratiempo[turn - 1].transform.localScale.z);

                }
                else
                {
                    barratiempo[turn - 1].transform.localScale = new Vector3(TIEMPO[turn - 1] / tiempoglabal, barratiempo[turn - 1].transform.localScale.y, barratiempo[turn - 1].transform.localScale.z);
                }
                   


            }


            else
            {
                if (automaticotiempo[turn - 1])
                {
                    TIEMPO[turn - 1] = tiempoautomatico;
                }
                else
                {
                    TIEMPO[turn - 1] = tiempoglabal;
                }
                
                puedebajar = false;
                guardaturn = turn;
                if (turn == 1)
                {
                    print("pso por aqui");
                    automatico1 = true;
                    automaticotiempo[turn - 1] = true;
                    TIEMPO[turn - 1] = tiempoautomatico;
                }
                if (turn == 2)
                {
                    automatico2 = true;
                }
                if (turn == 3)
                {
                    automatico3 = true;
                }
                if (turn == 4)
                {
                    automatico4 = true;
                }

            }
        }


        if (!juegobloqueado)
        {



            if (automatico1)
            {
                if (jugo[0] == false) 
                {
                    brutezaartificial1();
                //    automaticotiempo[turn - 1] = true;
                    TIEMPO[turn - 1] = tiempoautomatico;
                    if (automaticotiempo[0] && JUGADOR==1)
                    {
                        botonautomatico.SetActive(true);
                        automaticotoggle.isOn = true;
                        print("auto");
                    }
                }
                
                automatico1 = false;
            }
            if (automatico2)
            {
                if (jugo[1] == false)
                {
                    brutezaartificial2();
                    automaticotiempo[turn - 1] = true;
                    TIEMPO[turn - 1] = tiempoautomatico;
                    if (automaticotiempo[1] && JUGADOR == 2)
                    {
                        botonautomatico.SetActive(true);
                        automaticotoggle.isOn = true;
                    }
                }
                automatico2 = false;
            }
            if (automatico3)
            {
                if (jugo[2] == false)
                {
                    brutezaartificial3();
                    automaticotiempo[turn - 1] = true;
                    TIEMPO[turn - 1] = tiempoautomatico;
                    if (automaticotiempo[2] && JUGADOR == 3)
                    {
                        botonautomatico.SetActive(true);
                        automaticotoggle.isOn = true;
                    }
                }
                automatico3 = false;
            }
            if (automatico4)
            {
                if (jugo[3] == false)
                {
                    brutezaartificial4();
                    automaticotiempo[turn - 1] = true;
                    TIEMPO[turn - 1] = tiempoautomatico;
                    if (automaticotiempo[3] && JUGADOR == 4)
                    {
                     //   botonautomatico.SetActive(true);
                        automaticotoggle.isOn = true;
                    }
                }
                automatico4 = false;
            }
        }



    }
    public GameObject botonautomatico;
    bool boolautomatico = false;
    public void automatic()
    {

        //if (automaticotoggle.isOn == true)
        {
            boolautomatico = !boolautomatico;
            automaticotiempo[JUGADOR - 1] = boolautomatico;
            

            for (int k = 0; k < TIEMPO.Length; k++)
            {
                TIEMPO[k] = tiempoglabal;
                if (automaticotiempo[k])
                {
                    TIEMPO[k] = tiempoautomatico;
                }
                else
                {
                    TIEMPO[k] = tiempoglabal;
                }

            }

         //   botonautomatico.SetActive(false);
        }
        
    }

    IEnumerator quitar()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        QUITARLO = false;
    }
}
