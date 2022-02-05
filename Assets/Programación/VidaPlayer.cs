using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float Vida;
    public GameObject L;
    public GameObject M;
    public GameObject S;
    public float Puntaje;
    public Text Derrotados;
    public GameObject Enemigo;
    // Start is called before the first frame update
    void Start()
    {
        Vida = 100;
        L.SetActive(false);
        M.SetActive(false);
        S.SetActive(false);
        Puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Derrotados.text = "" + Puntaje;

        if (Vida > 100)
        {
            Vida = 100;
        }

        if (Vida > 76)
        {
            L.SetActive(false);
            M.SetActive(false);
            S.SetActive(false);
        }

        if (Vida <= 75)
        {
            L.SetActive(true);
            M.SetActive(false);
            S.SetActive(false);
        }

        if (Vida <= 50)
        {
            L.SetActive(false);
            M.SetActive(true);
            S.SetActive(false);
        }

        if (Vida <= 25)
        {
            L.SetActive(false);
            M.SetActive(false);
            S.SetActive(true);
        }

        if (Vida <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Puntaje == 100)
        {
            Destroy(Enemigo);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ArmaEnemiga")
        {
            Vida -= 25;
        }

        if (other.tag == "Cura")
        {
            Vida += 50;
        }
    }
}
