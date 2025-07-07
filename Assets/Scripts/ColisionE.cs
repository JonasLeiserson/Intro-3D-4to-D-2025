using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionE : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public DeteccionDeColisiones colisiones;
    public PuntosManager scoreManager;
    public int scorePoints;

    void Start()
    {
        UIInteractionMessage.SetActive(false);
        scoreManager = FindObjectOfType<PuntosManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract)
            {
                if (colisiones != null)
                {
                    Destroy(colisiones.gameObject);
                    scoreManager.SumarPuntuacion(scorePoints);
                    EndInteraction();
                }
                else
                {
                   
                    canInteract = false; 
                    UIInteractionMessage.SetActive(false);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        colisiones = other.GetComponent<DeteccionDeColisiones>();
        if (colisiones)
        {
            UIInteractionMessage.SetActive(true);
            canInteract = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        EndInteraction();
    }

    void EndInteraction()
    {
        UIInteractionMessage.SetActive(false);
        colisiones = null;
        canInteract = false;
    }
}