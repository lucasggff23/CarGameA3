using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float velocidade = 5f;
    public float faixaWidth = 2f;

    private int faixaInd = 1;
    private GameController gameController;

    
    void Start()
    {
       gameController = FindAnyObjectByType<GameController>();
    }

    // Update is called once per frame
    void Update()

       
    {
        if (!gameController.isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && faixaInd > 0)
            {
                faixaInd--;
                MoveCar();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && faixaInd < 2)
            {
                faixaInd++;
                MoveCar();
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                
                faixaInd = 1;
                MoveCar();
            }
        }

       void MoveCar() 
       {
        Vector3 targetPosition = new Vector3(faixaInd * faixaWidth - faixaWidth, transform.position.y, transform.position.z);
        transform.position = targetPosition;
       }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            
            
            StopAllCoroutines();


        }
    }
}
