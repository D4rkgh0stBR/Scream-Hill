using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CMD : MonoBehaviour
{
    public Text tMatouInimigo, tSuicida, tChave, tMunicao, tVida;
    public static int matouInimigo, suicida, chave, municao, vida;
    public GameObject gChave, gPorta, gMunicao;
    

    void Start()
    {
        vida = 100;
        municao = 10;
    }

    // Update is called once per frame
    void Update()
    {
        tMatouInimigo.text = matouInimigo.ToString();
        tSuicida.text = suicida.ToString();
        tChave.text = chave.ToString();
        tMunicao.text = municao.ToString();
        tVida.text = vida.ToString();
        if (chave == 1)
        {
            Destroy(this.gChave);
            gPorta.SetActive(false);
        }

        if (vida <= 0)
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void jogar()
    {
        SceneManager.LoadScene(1);
    }
}
