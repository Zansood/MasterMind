using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tira : MonoBehaviour
{
    //The script that manages the ball and others.
    public bool EsActive = false;
    public bool LinearComplete = false;

    public GameObject Soluciones;
    public GameObject Ballsobj;
    public Material[] CombinacionActual;
    public GameObject Flecha;

    public void ActualizaCombinacionActual()
    {
        CombinacionActual = Ballsobj.GetComponent<Balls>().CombinacionActual();
        LinearComplete = Ballsobj.GetComponent<Balls>().TiraComplete();
    }
    public void MostrarFlecha()
    {
        Flecha.SetActive(true);
    }
    public void EsconderFlecha()
    {
        Flecha.SetActive(false);
    }
}
