using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int Health;
    public int MaxHealth = 100;
    public Uimanager uimanager;
    // Start is called before the first frame update
    void Start()
    {
        uimanager = FindObjectOfType<Uimanager>();
        Health = MaxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActulizarVida(int puntosdedaño)
    {
      if (Health <= puntosdedaño)
        {
            return;
        }
        Health -= puntosdedaño;
        Debug.Log(Health);
        uimanager.UpdateHealth(Health);
    }
}
