using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTiras : MonoBehaviour
{
    public Tira[] tiras;
    public GameObject TiraActiveActual;
    public int numTiraActual;
    public GameObject panelLose;

    void Start()
    {
        ActiveTira(0);  
    }
    public void ActiveTira(int numTira)
    {
        for(int i = 0; i < tiras.Length;i++)
        {
            tiras[i].EsActive = false;
            tiras[i].GetComponent<Tira>().EsconderFlecha();
            
        }
        tiras[numTira].EsActive =  true;
        TiraActiveActual = tiras[numTira].gameObject;
        numTiraActual = numTira;
        if (numTira > 0)
        {
            tiras[numTira].GetComponent<Tira>().MostrarFlecha();
        }
    }

    public void CopiarTiraSiguiente()
    {
        Tira TiraNueva = tiras[numTiraActual];

        for(int i=0;i< 4; i++)
        {
            TiraNueva.Ballsobj.GetComponent<Balls>().ObjBalls[i].GetComponent<Ball>().CambiarColor(tiras[numTiraActual - 1].CombinacionActual[i]);
        }
    }
}
