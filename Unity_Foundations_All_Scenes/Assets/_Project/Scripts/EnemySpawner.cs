using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    public Transform[] enemySpawnPoints;
    public float enemyProjectileForce;

    public float timeBetweenSpawns;
    float timer;

    public void Construct(Object enemyPrefab)
    {
        enemyPrefab = enemyPrefab;
            

    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeBetweenSpawns)
        {
            timer = 0f;
            //spawn
            Transform chosenTransform = enemySpawnPoints[Random.Range(0, enemySpawnPoints.Length)];
            GameObject spawnedEnemy = Instantiate(enemyPrefab,chosenTransform.position, chosenTransform.rotation);
            spawnedEnemy.GetComponent<Rigidbody>().AddForce(spawnedEnemy.transform.forward * enemyProjectileForce, ForceMode.VelocityChange);
        }
    }
}
