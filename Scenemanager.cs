using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
   public void load()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}
