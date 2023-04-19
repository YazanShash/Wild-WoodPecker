using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadEasyScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMediumScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadHardScene()
    {
        SceneManager.LoadScene(3);
    }
}