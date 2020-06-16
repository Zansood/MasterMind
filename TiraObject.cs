using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiraObject : MonoBehaviour
{
    //Manage the ball set at the beginning.
    public bool LinearComplete = false;
    public GameObject Ballsobj;
    public Material[] CombinacionActual;

    public void ActualizaCombinacionActual()
    {
        CombinacionActual = Ballsobj.GetComponent<Balls>().CombinacionActual();
        LinearComplete = Ballsobj.GetComponent<Balls>().TiraComplete();
    }
}
