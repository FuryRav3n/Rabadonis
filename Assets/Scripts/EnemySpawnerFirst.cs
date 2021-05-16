using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerFirst : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject gun;
    public Rigidbody2D rb;
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
        if (Time.time > nextSpawn && gun.transform.parent != null)
        {
            nextSpawn = Time.time + SpawnRate;
            randomX = Random.Range(-10.5f, 5f);
            randomY = Random.Range(-5f, 5f);
            if (rb.position.x != randomX && rb.position.y != randomY)
            {
                whereToSpawn = new Vector2(randomX, randomY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
            else Debug.Log("Tried to spawn on head");
        }
    }
}
