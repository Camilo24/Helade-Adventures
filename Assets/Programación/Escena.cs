using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    public AudioSource Seleccionar;

    public void LoadScene(string sceneName)
    {
        Seleccionar.Play();
        SceneManager.LoadScene(sceneName);
    }
}
