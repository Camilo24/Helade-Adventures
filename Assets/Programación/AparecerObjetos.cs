using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerObjetos : MonoBehaviour
{
    public GameObject Gortyn;
    public GameObject Heraklion;
    public GameObject Knosos;
    public GameObject Kydonia;
    public GameObject Lato;
    public GameObject Ida;
    public GameObject Phaistos;
    public GameObject Zakros;
    // Start is called before the first frame update
    void Start()
    {
        Gortyn.SetActive(false);
        Heraklion.SetActive(false);
        Knosos.SetActive(false);
        Kydonia.SetActive(false);
        Lato.SetActive(false);
        Ida.SetActive(false);
        Phaistos.SetActive(false);
        Zakros.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gortyn")
        {
            Gortyn.SetActive(true);
            Heraklion.SetActive(false);
            Knosos.SetActive(false);
            Kydonia.SetActive(false);
            Lato.SetActive(false);
            Ida.SetActive(false);
            Phaistos.SetActive(false);
            Zakros.SetActive(false);
        }

        if (other.tag == "Heraklion")
        {
            Gortyn.SetActive(false);
            Heraklion.SetActive(true);
            Knosos.SetActive(false);
            Kydonia.SetActive(false);
            Lato.SetActive(false);
            Ida.SetActive(false);
            Phaistos.SetActive(false);
            Zakros.SetActive(false);
        }

        if (other.tag == "Knosos")
        {
            Gortyn.SetActive(false);
            Heraklion.SetActive(false);
            Knosos.SetActive(true);
            Kydonia.SetActive(false);
            Lato.SetActive(false);
            Ida.SetActive(false);
            Phaistos.SetActive(false);
            Zakros.SetActive(false);
        }

        if (other.tag == "Kydonia")
        {
            Gortyn.SetActive(false);
            Heraklion.SetActive(false);
            Knosos.SetActive(false);
            Kydonia.SetActive(true);
            Lato.SetActive(false);
            Ida.SetActive(false);
            Phaistos.SetActive(false);
            Zakros.SetActive(false);
        }

        if (other.tag == "Lato")
        {
            Gortyn.SetActive(false);
            Heraklion.SetActive(false);
            Knosos.SetActive(false);
            Kydonia.SetActive(false);
            Lato.SetActive(true);
            Ida.SetActive(false);
            Phaistos.SetActive(false);
            Zakros.SetActive(false);
        }

        if (other.tag == "Mount Ida")
        {
            Gortyn.SetActive(false);
            Heraklion.SetActive(false);
            Knosos.SetActive(false);
            Kydonia.SetActive(false);
            Lato.SetActive(false);
            Ida.SetActive(true);
            Phaistos.SetActive(false);
            Zakros.SetActive(false);
        }

        if (other.tag == "Phaistos")
        {
            Gortyn.SetActive(false);
            Heraklion.SetActive(false);
            Knosos.SetActive(false);
            Kydonia.SetActive(false);
            Lato.SetActive(false);
            Ida.SetActive(false);
            Phaistos.SetActive(true);
            Zakros.SetActive(false);
        }

        if (other.tag == "Zakros")
        {
            Gortyn.SetActive(false);
            Heraklion.SetActive(false);
            Knosos.SetActive(false);
            Kydonia.SetActive(false);
            Lato.SetActive(false);
            Ida.SetActive(false);
            Phaistos.SetActive(false);
            Zakros.SetActive(true);
        }
    }
}
