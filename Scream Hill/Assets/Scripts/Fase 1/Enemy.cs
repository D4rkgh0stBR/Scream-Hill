using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    NavMeshAgent agent;
    
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        Invoke("Suicidio", 10);

    }

    // Update is called once per frame
    void Update()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = player.transform.position;
        
    }

     void Suicidio()
     {
        Destroy(this.gameObject);
        CMD.suicida++;
     }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            
        }
    }
}
