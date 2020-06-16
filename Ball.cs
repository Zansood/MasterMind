using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Manage the ball, put the default color Manage coloring conditions.
    public EscogerColor escogerColor;
    public Material colorDefault;
    Mesh meshInical;
    public bool EsTiraObject;
    public Tira tira;


    void Awake()
    {
        meshInical = GetComponent<MeshFilter>().mesh;
        GetComponent<MeshFilter>().mesh = new Mesh();
        GetComponent<MeshRenderer>().material = colorDefault;
    }

    void OnMouseOver()
    {
        escogerColor.MostrarBallColors(gameObject);
    }
    public Material ColorBall()
    {
        return GetComponent<MeshRenderer>().material;
    }
    public void CambiarColor(Material ColorNuevo)
    {
        if(!EsTiraObject && !tira.EsActive)
        {
            AvisoTiraInactive();
            return;
        }


        GetComponent<MeshFilter>().mesh = meshInical;
        GetComponent<MeshRenderer>().material = ColorNuevo;
        if (EsTiraObject)
        {
            GetComponentInParent<Balls>().GetComponentInParent<TiraObject>().ActualizaCombinacionActual();
        }
        else
        {
            GetComponentInParent<Balls>().GetComponentInParent<Tira>().ActualizaCombinacionActual();
        }
    }
    public void AvisoTiraInactive()
    {
        print("Es not Active");
    }
}
