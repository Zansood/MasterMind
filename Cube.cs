using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public bool Mostrado = true;

    public void EscoderCube()
    {
        if(Mostrado)
        {
            gameObject.SetActive(false);
            Mostrado = false;
        }
        else
        {
            gameObject.SetActive(true);
            Mostrado = true;
        }
        
    }
   
}
