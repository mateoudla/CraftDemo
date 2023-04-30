using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public GameObject Madera;
    public GameObject Roca;
    public GameObject Mesa;
    public GameObject CampFire;
    public GameObject CampFire1;

    private bool tieneMadera = false;
    private bool tieneRoca = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Madera)
        {
            Debug.Log("Recogiste madera.");
            tieneMadera = true;
            Destroy(Madera);
        }

        if (other.gameObject == Roca)
        {
            Debug.Log("Recogiste rocas.");
            tieneRoca = true;
            Destroy(Roca);
        }

        if (other.gameObject == Mesa && tieneMadera && tieneRoca)
        {
            Debug.Log("¡Hiciste una fogata!");
            CampFire.GetComponent<Renderer>().enabled = true;

        }

        if (other.gameObject == Mesa && (!tieneMadera || !tieneRoca))
        {
            Debug.Log("Necesitas madera y rocas para hacer una fogata.");
        }

        if (other.gameObject == Mesa && tieneMadera && tieneRoca)
        {
            CampFire1.GetComponent<Renderer>().enabled = true;

        }

    }
}

