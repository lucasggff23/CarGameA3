using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public GameObject painelDeGameOver;
    public TextMeshProUGUI textoDeTempoFinal;
    public TextMeshProUGUI textoDeHighScore;
    private float startTime;

    public int tempoAtual;


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Time.timeScale = 1f;
        startTime = Time.time;
        painelDeGameOver.SetActive(false);
        textoDeHighScore.text = "High Score: " + PlayerPrefs.GetFloat("HighScore", 0).ToString("F2") + "s";
    }

    // Update is called once per frame
    void Update()
    {
        float tempoAtual = Time.time - startTime;
        textoDeTempoFinal.text = "Time: " + tempoAtual.ToString("F2") + "s";

        tempoAtual = Time.time - startTime; // Atualiza a variável de instância
        textoDeTempoFinal.text = "Time: " + tempoAtual.ToString("F2") + "s";
    }

    public void GameOver()
    {
        Time.timeScale = 0f;

        painelDeGameOver.SetActive(true);
        textoDeTempoFinal.text = "TEMPO: " + tempoAtual;

        if (tempoAtual > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", tempoAtual );
        }

        textoDeHighScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");
    }

   
}
