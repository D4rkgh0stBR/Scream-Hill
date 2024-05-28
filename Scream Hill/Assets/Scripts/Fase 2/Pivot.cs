using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    public Transform player; // Referência para a posição do jogador
    public float speed = 2.0f; // Velocidade do inimigo
    private Vector3 playerPosition;
    private float followDelay = 1.0f; // Atraso de 1 segundo
    private float timer;

    void Start()
    {
        // Inicializa o temporizador
        timer = followDelay;
        // Pega a posição inicial do jogador
        playerPosition = player.position;
    }

    void Update()
    {
        // Atualiza o temporizador
        timer -= Time.deltaTime;

        // Se o temporizador chegar a zero, atualiza a posição do jogador e reseta o temporizador
        if (timer <= 0f)
        {
            playerPosition = player.position;
            timer = followDelay;
        }

        // Move o inimigo na direção da posição armazenada do jogador
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
