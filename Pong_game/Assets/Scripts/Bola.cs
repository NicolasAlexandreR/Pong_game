using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{    
    //Váriavel que vai checar o Rigidbody da bola e dar velocidade a ela
    public Rigidbody2D rbBola; 
    private Vector2 velocidadeBola; 
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //vector2 (movimentação da bola), vai ir pro lado esquerdo
        velocidadeBola.x = -velocidade; 

        //o Rigidbody vai mudar a posição da bola com a velocidade dada a váriavel velocidadeBola
        rbBola.velocity = velocidadeBola;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
