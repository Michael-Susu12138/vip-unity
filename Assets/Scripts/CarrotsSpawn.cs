using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotsSpawn : MonoBehaviour
{

    public GameObject Carrot;

    IEnumerator Start()
    {
        while(true){
            Vector2 spawnPos = new Vector2(Random.Range(9,14),Random.Range(-5f, 5f) );
            Instantiate(Carrot, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(3.1f);
        }

        // Vector2 spawnPos = new Vector2(Random.Range(9,14),Random.Range(-5f, 5f) );
        // Instantiate(Enemy, spawnPos, Quaternion.identity);
        // yield return new WaitForSeconds(.7f);
    }
}
