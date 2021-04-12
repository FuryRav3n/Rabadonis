﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerSecond : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    float randomX;
    float randomY;
    Vector2 whereToSpawn;
    public float SpawnRate = 2f;
    float nextSpawn = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            randomX = Random.Range(9f, 26f);
            randomY = Random.Range(-6f, 15f);
            whereToSpawn = new Vector2(randomX, randomY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}