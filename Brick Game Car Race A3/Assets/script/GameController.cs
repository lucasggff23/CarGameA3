using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour

{
    public TextMeshProUGUI tempoText;
    public GameObject painelDeGameOver;
    public TextMeshProUGUI textoDePontuacaoFinal;
    public TextMeshProUGUI gameOverText;
    private float startTime;
    public bool isGameOver;
    public float tempoAtual;
    public float currentTime;
    float tempo;


    void Start()
    {
        startTime = Time.time;
        isGameOver = false;
       
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        void Update()
        {
            if (!isGameOver)
            {
                tempoAtual = Time.time - startTime;
                tempoText.text = "Time: " + tempoAtual.ToString("F2") + "s";
            }

            /* if (!isGameOver)
             {
                 tempoAtual = Time.time - startTime;
                 tempoText.text = "Time: " + tempoAtual.ToString("F2") + "s";
             }*/


        }


           
    }
}

