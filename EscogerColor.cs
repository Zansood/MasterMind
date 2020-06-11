using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscogerColor : MonoBehaviour
{
    public GameObject[] BallColors;
    public bool Mostrardo = false;
    public GameObject BallLamante;




   
    void OnMouseExit()
    {
        EsconderBallColors();
    }
   public void MostrarBallColors(GameObject ballLamante)
    {
        if(!ballLamante.GetComponent<Ball>().tira.EsActive)
        {
            return;
        }
        transform.position = ballLamante.transform.position;
        BallLamante = ballLamante;
        for(int i = 0; i< BallColors.Length; i++)
        {
            BallColors[i].SetActive(true);
        }
        Mostrardo = true;
    }
    public void EsconderBallColors()
    {
        for(int i = 0;i < BallColors.Length; i++)
        {
            BallColors[i].SetActive(false);
        }
        Mostrardo = false;
    }
}
