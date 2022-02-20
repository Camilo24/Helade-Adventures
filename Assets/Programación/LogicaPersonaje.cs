using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public bool conArma;
    public Animator anim;
    public AudioSource Espadazo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (conArma)
            {
                Espadazo.Play();
                anim.SetTrigger("GolpeoEspada");
            }
        }
    }
}
