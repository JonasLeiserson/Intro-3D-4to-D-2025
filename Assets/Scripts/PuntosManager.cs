using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosManager : MonoBehaviour
{
    public int puntuacion;
    public Uimanager uimanager;
    // Start is called before the first frame update
    void Start()
    {
        uimanager = FindObjectOfType<Uimanager>();
        puntuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SumarPuntuacion()
    {
        puntuacion++;
        Debug.Log("+1");
        uimanager.UpdateScore(puntuacion);
    }
    public void SumarPuntuacion(int scorePoints)
    {
        puntuacion += scorePoints;
        uimanager.UpdateScore(puntuacion);

    }
}
