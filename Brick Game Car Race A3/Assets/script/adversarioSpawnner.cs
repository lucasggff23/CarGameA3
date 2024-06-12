using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adversarioSpawnner : MonoBehaviour
{
    public GameObject adverPrefab;
    public float intervaloSpawnInicial = 2f;
    public float intervaloSpwanMinimo = 0.5f;
    public float intevalorSpawnDiminuicao = 0.1f;
    public float velocidadeInicial = 5f;
    public float intervaloAumentoVelocidade = 10f;
    public float aumetoVelocidade = 1f;
    public float faixaWidth = 2f;

    public float timer = 0f;
    public float aumentoTimer = 0f;
    public float intervaloSpawnAtual;
    public float velocidadeAtualAdversario;
    void Start()
    {
        intervaloSpawnAtual = intervaloSpawnInicial;
        velocidadeAtualAdversario = velocidadeInicial;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        aumentoTimer += Time.deltaTime;

        if(timer > intervaloSpawnInicial)
        {
            spawnAdver();
            timer = 0f;
        }

        if(aumentoTimer >= intervaloAumentoVelocidade)
        {
            aumentoDificuldade();
            aumentoTimer = 0f;
        }
    }
    void spawnAdver()
    {
        int numeroAdver = Random.Range(1, 3);
        for (int i = 0; i < numeroAdver; i++)
        { 
            int faixaInd = Random.Range(0, 3);
            Vector3 posicaoSpawn = new Vector3(faixaInd * faixaWidth - faixaWidth, transform.position.y + 10f, 0);
            GameObject adversario = Instantiate(adverPrefab,posicaoSpawn, Quaternion.identity);
            aAdversarioMovement adversarioMovement = adversario.AddComponent<aAdversarioMovement>();
            adversarioMovement.speed = velocidadeAtualAdversario;
        }
    }

    void aumentoDificuldade()
    {
        velocidadeAtualAdversario += aumetoVelocidade;
        intervaloSpawnAtual = Mathf.Max(intervaloSpwanMinimo, intervaloSpawnAtual - intevalorSpawnDiminuicao);
        /*Debug.Log("Velocidade do adversário aumentada para " + velocidadeAtualAdversario);
        Debug.Log("Intervalo de Adversario diminuido para " + intervaloSpawnAtual);*/
    }
}
