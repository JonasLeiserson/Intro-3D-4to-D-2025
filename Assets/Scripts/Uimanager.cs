using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Uimanager : MonoBehaviour
{

    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vida;
    public TextMeshProUGUI GanasteTxt;
    public GameObject ImagenGanar;
    public GameObject ImagenPerder;
    // Start is called before the first frame update
    void Start()
    {
        ImagenGanar.SetActive(false);
        ImagenPerder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int score)
    {
        puntuacion.text = "puntuacion: " + score.ToString();
    }
    public void UpdateHealth(int health)
    {
        vida.text = "vida: " + health.ToString();
    }
    public void Ganar(int puntuacion)
    {
        ImagenGanar.SetActive(true);
        GanasteTxt.text = "¡¡¡Ganaste!!!  puntuacion:" + puntuacion;
    }
    public void Perder()
    {
        ImagenPerder.SetActive(true);
        StartCoroutine(Esperar());
    }
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("FPS parkour");
    }
}
