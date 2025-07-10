using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    public Uimanager uimanager;
    public PuntosManager puntosManager;
    // Start is called before the first frame update
    void Start()
    {
        uimanager = FindObjectOfType<Uimanager>();
        puntosManager = FindObjectOfType<PuntosManager>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            uimanager.Ganar(puntosManager.puntuacion);
            Destroy(gameObject);
        }
    }
}
