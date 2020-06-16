using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soluciones : MonoBehaviour
{
    //Check the selected color that matches the set.
    public bool Facil;
    public GameObject[] SolucionesObj;
    public Material white;
    public Material black;
    public Material colorDefault;
    public bool Solucionada;
    public TiraObject tiraObject;
    public Mesh MeshInicial;
    public ControlTiras controlTiras;
    public Difficult dificult;
    public GameObject panelWin;

    public void Awake()
    {
        MeshInicial = GetComponentInChildren<MeshFilter>().mesh;

        for(int i = 0;i < SolucionesObj.Length;i++)
        {
            SolucionesObj[i].GetComponent<MeshFilter>().mesh = new Mesh();
        }

    }
    public void ColorSolucion()
    {
        if(Solucionada)
        {
            AvisoTiraSolucionada();
            return;
        }

        Tira tira = GetComponentInParent<Tira>();

        if(!tira.LinearComplete)
        {
            AvisoTiraIncomplte();
            return;
        }
        if(!tiraObject.LinearComplete)
        {
            AvisoTiraObjectIncomplte();
            return;
        }

        Material[] soluciones = new Material[4];
        soluciones = Calcular();


        /*if(!dificult.facil)
        {
            soluciones = DesordenarSoluciones(soluciones);
        }*/
        for (int i = 0; i < SolucionesObj.Length; i++)
        {
            SolucionesObj[i].GetComponent<MeshRenderer>().material = soluciones[i]; 

            if(soluciones[i] != colorDefault)
            {
                SolucionesObj[i].GetComponent<MeshFilter>().mesh = MeshInicial;
            }
        }
        AvisoSolucionCorrectamente();
        controlTiras.ActiveTira (controlTiras.numTiraActual + 1);

        Solucionada = true;
    }
    public Material[]  Calcular()
    {
        Material[] Result = new Material[4];
        Tira tira = GetComponentInParent<Tira>();
        bool existe = false;

        for (int x = 0; x < tira.CombinacionActual.Length; x++)
        {
            existe = false;
            for (int i = 0; i < tira.CombinacionActual.Length; i++)
            {
                if (tira.CombinacionActual[x].color == tiraObject.CombinacionActual[i].color)
                {
                    existe = true;
                    if (i == x)
                    {
                        Result[x] = white;
                        break;
                    }else {
                        if(Result[x] != white)
                        {
                            Result[x] = black;
                        }
                    }
                }
                if (!existe)
                {
                    Result[x] = colorDefault;
                }
                

            }
        }
        if(Ganaste(Result))
        {
            AvisoGanaste();
        }

        return Result;
    }
   


    public bool Ganaste(Material[] soluciones)
    {
        bool Result = true;

        for(int i =0; i<soluciones.Length;i++)
        {
            if(soluciones[i]!=white)
            {
                return false;
            }
        }
        return Result;

    }


    Material[] DesordenarSoluciones(Material[] materiales)
    {
        Material[] Result = new Material[4];
        for(int i = 0; i < materiales.Length; i++)
        {
            Material temp = materiales[i];
            int RandomIndex = Random.Range(i, materiales.Length);
            materiales[i] = materiales[RandomIndex];
            materiales[RandomIndex] = temp;
        }
        return materiales;
    }

    public void AvisoTiraSolucionada()
    {
        print("Esta tira ya esta solucionada");
    }
    public void AvisoTiraIncomplte()
    {
        print("Choose object to complete");
    }
    public void AvisoTiraObjectIncomplte()
    {
        print("object no complete");
    }
    public void AvisoSolucionCorrectamente()
    {
        print("Solucion correct");
    }
    public void AvisoGanaste()
    {
        print("Great Win!");
    }


}
