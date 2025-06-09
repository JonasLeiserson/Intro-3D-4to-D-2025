using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EsperarSegundos : MonoBehaviour
{
    public float tiempoDeEspera;
    float timeElapsed;
    public Transform cuboTR;
    void Start()
    {
        //InvokeRepeating(nameof(ElevarCubo), 0, tiempoDeEspera);
        StartCoroutine(EsperarAlaElevacion());
    }
    void Update()
    {
        //Debug.Log(Time.deltaTime);
        
        //if (timeElapsed >= tiempoDeEspera)
        //{
        //    Debug.Log("Tiempo cumplido");
        //    timeElapsed = 0;
        //    ElevarCubo();
        //}
        //else
        //{
        //    Debug.Log(timeElapsed += Time.deltaTime);
        //}
    }
    IEnumerator EsperarAlaElevacion()
    {
        while(true)
        {
            yield return new WaitForSeconds(tiempoDeEspera);
            ElevarCubo();
        }
    }
    void ElevarCubo()
    {
        cuboTR.position += Vector3.up * 1;
    }
}
