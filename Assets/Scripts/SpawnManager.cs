using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject circlePrefab;
    private int spawnPosX = 8;
    private int spawnPosY = 4;
    void Start()
    {
        SpawnCircles();
    }

    void SpawnCircles()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 spawnPos = RandomSpawnPos();
            Instantiate(circlePrefab, spawnPos, circlePrefab.transform.rotation);
        }
    }

    Vector2 RandomSpawnPos()
    {
        return new Vector2(Random.Range(-spawnPosX, spawnPosX), Random.Range(-spawnPosY, spawnPosY));
    }
}
