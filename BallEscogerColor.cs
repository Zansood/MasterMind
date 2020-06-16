using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEscogerColor : MonoBehaviour
{
    //Manage color selection.
    Material _color;
    public EscogerColor escogerColor;

    void Awake()
    {
        _color = GetComponent<MeshRenderer>().material;

        
    }
    void OnMouseDown()
    {
        escogerColor.BallLamante.GetComponent<Ball>().CambiarColor(_color);
    }
}
