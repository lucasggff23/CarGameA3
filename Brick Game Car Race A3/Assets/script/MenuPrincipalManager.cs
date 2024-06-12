using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string jogo;

    [SerializeField]private GameObject painelMenuPrincipal;
    [SerializeField]private GameObject painelCreditos;
    public void Jogar()
    {
        SceneManager.LoadScene("jogo");
    }

    public void AbrirCreditos()
    {
        painelMenuPrincipal.SetActive(false);
        painelCreditos.SetActive(true);
    }
    
    public void FecharCreditos()
    {
        painelCreditos.SetActive(false);
        painelMenuPrincipal.SetActive(true) ;
    }
}
