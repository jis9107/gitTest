using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private GameObject gasPrefab;
    [SerializeField] private Transform[] spawnPoints;
    private float timer;
    
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2f)
        {
            SpawnItem(Random.Range(0, spawnPoints.Length));
            timer = 0f;
        }
    }

    void SpawnItem(int ranIndex)
    {
        GameObject instance = Instantiate(gasPrefab, spawnPoints[ranIndex].position, Quaternion.identity);
    }
}
