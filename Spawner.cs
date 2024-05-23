using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    //Attaching Bomb Prefab
    public GameObject bombPrefab;
    private float minX = -2.55f;
    private float maxX = +2.55f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerBomb());
    }

    //Starting the spawning with delay
    IEnumerator SpawnerBomb(){

        yield return new WaitForSeconds(Random.Range(0f, 1f));
        //Code of Copying
        Instantiate(bombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);
        //Code of Starting Coroutine within Coroutine
        StartCoroutine(SpawnerBomb());
    }
}
