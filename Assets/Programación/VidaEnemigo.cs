using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{
    public float Vida;
    public GameObject Enemigo;
    public VidaPlayer VidaPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Vida = 100;
    }

    // Update is called once per frame
    void Update()
    {

        if (Vida > 100)
        {
            Vida = 100;
        }

        if (Vida <= 0)
        {
            VidaPlayer.Puntaje += 1;
            Enemigo.SetActive(false);
            Vida = 100;
            Enemigo.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Arma")
        {
            Vida -= 25;
        }
    }
}
