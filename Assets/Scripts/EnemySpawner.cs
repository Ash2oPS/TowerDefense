using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject _enemyPrefab = null;
    private GameObject enemyPrefab { get { return _enemyPrefab; } set { _enemyPrefab = value; } }

    public float _spawnDelay = 0.5f;
    private float spawnDelay { get { return _spawnDelay; } set { _spawnDelay = value; } }


    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnDelay);
    }

    private void Update()
    {
        
    }

    private void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.z += Random.Range(-3.0f, 3.0f);
        Instantiate(enemyPrefab, spawnPosition, transform.rotation);
    }
}
