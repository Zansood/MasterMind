using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiraObject : MonoBehaviour
{
    //public bool EsActive = false;
    public bool LinearComplete = false;

    //public GameObject Soluciones;
    public GameObject Ballsobj;
    public Material[] CombinacionActual;

    public void ActualizaCombinacionActual()
    {
        CombinacionActual = Ballsobj.GetComponent<Balls>().CombinacionActual();
        LinearComplete = Ballsobj.GetComponent<Balls>().TiraComplete();
    }
}
