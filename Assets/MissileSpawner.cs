using System.Collections;
using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    public GameObject missilePrefab;
    public Camera cam;
    public float spawnInterval = 3f;     // Was 6f in Level 1
    public float missileSpeed = 18f;    // Was 10f in Level 1

    void Start()
    {
        StartCoroutine(SpawnMissileRoutine());
    }

    IEnumerator SpawnMissileRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnMissile();
        }
    }

    void SpawnMissile()
    {
        int side = Random.Range(0, 4);
        Vector2 viewportPos = Vector2.zero;

        switch (side)
        {
            case 0: viewportPos = new Vector2(-0.05f, Random.value); break;
            case 1: viewportPos = new Vector2(1.05f, Random.value); break;
            case 2: viewportPos = new Vector2(Random.value, -0.05f); break;
            case 3: viewportPos = new Vector2(Random.value, 1.05f); break;
        }

        Vector3 worldPos = cam.ViewportToWorldPoint(viewportPos);
        worldPos.z = 0;

        GameObject missileInstance = Instantiate(missilePrefab, worldPos, Quaternion.identity);
        MissileBehavior mb = missileInstance.GetComponent<MissileBehavior>();
        if (mb != null)
            mb.speed = missileSpeed;
    }
}