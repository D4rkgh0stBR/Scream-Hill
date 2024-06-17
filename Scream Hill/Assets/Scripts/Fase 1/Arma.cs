using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arma : MonoBehaviour
{
    [SerializeField] private ParticleSystem particulas;
    public Camera gamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray rayPoint = gamera.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
            RaycastHit alvo;
            if (CMD.municao >= 1)
            {
                if (Physics.Raycast(rayPoint, out alvo, Mathf.Infinity))
                {
                    if (alvo.collider.CompareTag("Enemy"))
                    {
                        Destroy(alvo.transform.gameObject);
                        CMD.matouInimigo++;

                    }
                    CMD.municao--;
                    Debug.Log("Shoot Right");
                }
            }

            particulas.Play();
            StartCoroutine("Parar");

        }
        IEnumerator Parar()
        {
            yield return new WaitForSeconds(2);
            particulas.Stop();
        }
    }
}
