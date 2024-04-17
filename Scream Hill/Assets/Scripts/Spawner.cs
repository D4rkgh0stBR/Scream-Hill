using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        StartCoroutine (EnemyGhost());
    }
    
    IEnumerator EnemyGhost()
    {
        float x = Random.Range (-54f, 21.5f);
        float y = 1;
        float z = Random.Range(-15f, 7.2f);
        while (true)
        {
            Instantiate(Enemy, new Vector3(x, y, z), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
           
    }

}
