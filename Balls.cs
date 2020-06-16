using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    //Manage 4 balls and manage colors.
    public GameObject[] ObjBalls;
    public Material[] Colors;
    public Material colorDefault;

    public Material[] CombinacionActual()
    {
        Material[] Result = new Material[4];
        for(int i=0; i<ObjBalls.Length; i++)
        {
            Result[i] = ObjBalls[i].GetComponent<Ball>(). ColorBall();
        }
        return Result; 
    }
    public void CombinarAleator()
    {
        for (int i = 0; i < ObjBalls.Length; i++)
        {
            ObjBalls [i].GetComponent<Ball> ().CambiarColor (Colors [Random.Range(0, Colors.Length)]);
        }
    }
    public bool TiraComplete()
    {
        bool Result = true; 
        for (int i = 0; i < ObjBalls.Length; i++)
        {
            if (ObjBalls[i].GetComponent<Ball>().ColorBall().color == colorDefault.color)
            {
                return false;
            }
        }
        return Result;
       
    }
}
