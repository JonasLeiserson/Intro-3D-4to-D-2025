using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public PuntosManager puntosManager;
    public MercaderiaScript mercaderiaScript;
    void Start()
    {
        mercaderiaScript = GetComponent<MercaderiaScript>();
        puntosManager = FindObjectOfType<PuntosManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);
            puntosManager.SumarPuntuacion(mercaderiaScript.scorePoints);

        }
    }
}
