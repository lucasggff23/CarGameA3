using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aAdversarioMovement : MonoBehaviour
{

    public float speed = 5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -11f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Jogador"))
        {
            GameManager.instance.GameOver();

            Debug.Log("Game Over");
            StopAllCoroutines();
        }
    }
}
