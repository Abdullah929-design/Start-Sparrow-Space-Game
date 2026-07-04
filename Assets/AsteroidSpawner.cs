using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float secondsDifference = 0.8f;          
    public Vector2 forceRange = new Vector2(8f, 14f); 
    public Camera cam;
    float timer;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            spawnAsteroid();
            timer += secondsDifference;
        }
    }

    public void spawnAsteroid()
    {
        int side = Random.Range(0, 4);
        Vector2 spawnPoint = Vector2.zero;
        Vector2 direction = Vector2.zero;

        switch (side)
        {
            case 0:
                spawnPoint.x = 0; spawnPoint.y = Random.value;
                direction = new Vector2(1f, Random.Range(-1f, 1f)); break;
            case 1:
                spawnPoint.x = 1; spawnPoint.y = Random.value;
                direction = new Vector2(-1f, Random.Range(-1f, 1f)); break;
            case 2:
                spawnPoint.y = 0; spawnPoint.x = Random.value;
                direction = new Vector2(Random.Range(-1f, 1f), 1f); break;
            case 3:
                spawnPoint.y = 1; spawnPoint.x = Random.value;
                direction = new Vector2(Random.Range(-1f, 1f), -1f); break;
        }

        Vector3 worldpoint = cam.ViewportToWorldPoint(spawnPoint);
        worldpoint.z = 0;

        GameObject selectionAsteroid = asteroidPrefabs[Random.Range(0, asteroidPrefabs.Length)];
        GameObject asteroidInstance = Instantiate(
            selectionAsteroid, worldpoint,
            Quaternion.Euler(0, 0, Random.Range(0, 360))
        );

        Rigidbody rb = asteroidInstance.GetComponent<Rigidbody>();
        rb.velocity = direction.normalized * Random.Range(forceRange.x, forceRange.y);
    }
}