using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Uimanager : MonoBehaviour
{

    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int score)
    {
        puntuacion.text = score.ToString();
    }
    public void UpdateHealth(int health)
    {
        vida.text = health.ToString();
    }
}
