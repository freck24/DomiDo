using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gestor : MonoBehaviour
{
    // Start is called before the first frame update


    public int sala;
    public int let;
    public string[] letras = { "a", "b", "c", "d" };
    public string salareal;


    public void brutezaartificial2()
    {
        int k = 0;
            while (BUTTON2[j2[k]].activeSelf==false && activos[j2[k]]==false && k<7)
            {
            i = j2[k] - 1;
            k++;
           }

      
        print("es el" + i);
        if (codigos[i].i == n1)
        {
            der();

            if(turn==2)
            print("jugo derechA");
        }
        else if (codigos[i].j == n2)
        {
            izq();

            if (turn == 2)
                print("jugo IZQUIERDA");
        }




    }





    public void creaciondesala()
    {
        sala = Random.Range(1000, 9999);
        let = Random.Range(0, letras.Length);
        salareal = "" + letras[let] + sala;
        
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
    public void contar1()
    {
        cantidadfichas1 = 0;
        cantidadfichas2 = 0;
        cantidadfichas3 = 0;
        cantidadfichas4 = 0;
       
        for (int k = 0; k < button.Length; k++)
        {  if(button[k].activeSelf)
            cantidadfichas1 += 1;
            
            
            if(BUTTON2[k].activeSelf)
            cantidadfichas2 += 1;

            if (BUTTON3[k].activeSelf)
                cantidadfichas3 += 1;

            if (BUTTON4[k].activeSelf)
                cantidadfichas4 += 1;

        }

        if (cantidadfichas1==0)
        {
            StartCoroutine(nuevojuego());
           
            if (JUGADOR == 1)
            {
                MENSAJEGANAR[0].SetActive(true);
            }
            else
            {
                MENSAJEGANAR[1].SetActive(true);
            }
           
        }  if (cantidadfichas2==0)
        {
            StartCoroutine(nuevojuego());

            if (JUGADOR == 2)
            {
                MENSAJEGANAR[0].SetActive(true);
            }
            else
            {
                MENSAJEGANAR[1].SetActive(true);
            }
        }  if (cantidadfichas3==0)
        {
            StartCoroutine(nuevojuego());
            if (JUGADOR == 3)
            {
                MENSAJEGANAR[0].SetActive(true);
            }
            else
            {
                MENSAJEGANAR[1].SetActive(true);
            }
        }  if (cantidadfichas4==0)
        {
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





     }


    IEnumerator nuevojuego()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(0);
    }




    public quitar[] cogen;
    public void fichas()
    { 
        {
            for(int k=0; k < 7; k++)
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
            
            
            for(int k=0; k < 7; k++)
            {
                j2[k] = Random.Range(0, 28);

               j2i[k]= codigos[j2[k]].i; //hacerlo con los demas
               j2j[k]= codigos[j2[k]].j;

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
            } for(int k=0; k < 7; k++)
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
            
            for(int k=0; k < 7; k++)
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
        while(k<7 && (codigos[j2[k]].i!=n1 || codigos[j2[k]].j != n1|| codigos[j2[k]].i != n2|| codigos[j2[k]].j != n2))
        { 
            i = j2[k];
            if (i == n1)
            {
                der();
            }
            else if(i==n2)
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
        for(int r = 0; r<7; r++)
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

    void Start()
    {
        alea();
        turnotext.text = "JUGADOR " + turn;

        if (JUGADOR == 1)
        {
            creaciondesala();
        }

    }
    public void der()
    {
        derecha = true;
        tirar();
    }
    public void izq()
    {
        derecha = false;
        tirar();
    }
    #region


    public bool QUITARLO = false;

    public GameObject ladoderecho;
    public GameObject ladoizquierdo;
    public bool primeravez2 = true;

    public bool lado1=false;
    public bool lado2=false;
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

            if(lado1==true && lado2 == false)
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
            tirar();
        }

        LadoTablero();
    } public void b1()
    {
        i = 1;
        if (primerajugada)
        {
            tirar();
        }


        LadoTablero();
    } public void b2()
    {
        i = 2;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b3()
    {
        i = 3;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b4()
    {
        i = 4;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b5()
    {
        i = 5;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b6()
    {
        i = 6;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b7()
    {
        i = 7;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b8()
    {
        i = 8;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b9()
    {
        i = 9;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b10()
    {
        i = 10;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b11()
    {
        i = 11;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b12()
    {
        i = 12;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b13()
    {
        i = 13;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b14()
    {
        i = 14;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b15()
    {
        i = 15;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b16()
    {
        i = 16;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b17()
    {
        i = 17;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b18()
    {
        i = 18;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b19()
    {
        i = 19;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    } public void b20()
    {
        i = 20;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }
    public void b21()
    {
        i = 21;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }
    public void b22()
    {
        i = 22;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }
    public void b23()
    {
        i = 23;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }
    public void b24()
    {
        i = 24;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }
    public void b25()
    {
        i = 25;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }
    public void b26()
    {
        i = 26;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }
    public void b27()
    {
        i = 27;
        if (primerajugada)
        {
            tirar();
        }
        LadoTablero();
    }


    #endregion









    public void logica()
    {
     



        {
            if (derecha)
            {

                if (codigos[i].doble == false)

                {
                    pieza[i].position = p1.arriba.position;
                    p1 = codigos[i];
                    
                }
                else
                {
                    pieza[i].position = p1.derecha.position;
                    p1 = codigos[i];
                    n2 = p1.j;

                }




            }
            else
            {
                if (codigos[i].doble == false)

                {
                    pieza[i].position = p2.abajo.position;
                    p2 = codigos[i];
                }
                else
                {
                    pieza[i].position = p2.izquierda.position;
                    p2 = codigos[i];
                    n1 = p2.j;
                }

            }



        }











    }

    public GameObject Novalido;


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

    public void comprobar()
    {  
        for(int k=0; k<codigos.Length; k++)
        {
            activos[k] = false;
            botones[k].color = c;
            botones2[k].color = c;
            botones3[k].color = c;
            botones4[k].color = c;
            if (codigos[k].j == n1 || codigos[k].i == n1 || codigos[k].i == n2 || codigos[k].j == n2)
            {
                
                activos[k] = true;
                botones[k].color = Color.white;
                botones2[k].color = Color.white;
                botones3[k].color = Color.white;
                botones4[k].color = Color.white;
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
           
            if (activos[k] && button[k].activeSelf || activos[k] && BUTTON2[k].activeSelf || activos[k] && BUTTON3[k].activeSelf|| activos[k] && BUTTON4[k].activeSelf)
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
                    Novalido.SetActive(false);
                    Novalido.SetActive(true);
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
                    Novalido.SetActive(false);
                    Novalido.SetActive(true);
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
                    Novalido.SetActive(false);
                    Novalido.SetActive(true);
                    turnando();
                    va = false;
                }

                novbool = false;
            }
        }
        else
        {
            mensajebloqueo.SetActive(true);
        }

    }








    public void turnando()
    {  
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
        else { BLOQUEADOR.SetActive(true);}


        turnotext.text = "JUGADOR " + turn;
        
    }

    public void tirar()
    {

        turnando();
      

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
                else if (codigos[i].j ==n2)
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
        ladoizquierdo.SetActive(false);
        ladoderecho.SetActive(false);
        va = false;
        StartCoroutine(contando());


        while (va ==false && juegobloqueado==false)
        Comprobadordeturno();

    }
  
    IEnumerator contando()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        contar1();


       
        if (turn == 2)
            print("jugara el 2]");


        yield return new WaitForSecondsRealtime(0.5f);
       
        if (turn==2)
        brutezaartificial2();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator quitar()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        QUITARLO = false;
    }
}
