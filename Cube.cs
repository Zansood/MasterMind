using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Turn on and turn off the hint.
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
