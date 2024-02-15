using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    //Se você veio checar o código, saiba q vou mexer mais nele amanha(15/02), por enquanto a bola vai
    //continuar tendo a velocidade diminuida
    
    //Váriavel que vai checar o Rigidbody da bola e dar velocidade a ela
    public Rigidbody2D rbBola; 
    private Vector2 velocidadeBola; 
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //vector2 (movimentação da bola), vai ir pro lado esquerdo
        velocidadeBola.x = -velocidade; 

        //o Rigidbody vai mudar a posição da bola com a velocidade dada a váriavel velocidade
        rbBola.velocity = velocidadeBola;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
