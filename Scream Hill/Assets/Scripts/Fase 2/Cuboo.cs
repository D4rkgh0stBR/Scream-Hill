using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuboo : MonoBehaviour
{
    public Transform playerpos;
    public Transform playerpospassadax, playerpospassaday, playerpospassadaz;
    public AudioSource cima, baixo, esquerda, direita, frente, tras;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerpos.transform.position.x > playerpospassadax.transform.position.x)
        {
            frente.Play();
            print(playerpos);
        }

        if (playerpos.transform.position.x < playerpospassadax.transform.position.x)
            tras.Play();

        if (playerpos.transform.position.y > playerpospassaday.transform.position.y)
            cima.Play();

        if (playerpos.transform.position.y < playerpospassaday.transform.position.y)
            baixo.Play();

        if (playerpos.transform.position.z > playerpospassadaz.transform.position.z)
            esquerda.Play();

        if (playerpos.transform.position.z < playerpospassadaz.transform.position.z)
            direita.Play();

    }
}


