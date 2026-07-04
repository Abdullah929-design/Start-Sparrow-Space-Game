using System.Collections;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    public GameObject minePrefab;
    public Camera cam;
    public float spawnInterval = 2f;    
    public float mineLifetime = 4f;

    void Start()
    {
        StartCoroutine(SpawnMineRoutine());
    }

    IEnumerator SpawnMineRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnMine();
        }
    }

    void SpawnMine()
    {
        Vector2 viewportPos = new Vector2(
            Random.Range(0.1f, 0.9f),
            Random.Range(0.1f, 0.9f)
        );
        Vector3 worldPos = cam.ViewportToWorldPoint(viewportPos);
        worldPos.z = 0;

        GameObject mineInstance = Instantiate(minePrefab, worldPos, Quaternion.identity);
        MineBehavior mineBehavior = mineInstance.GetComponent<MineBehavior>();
        if (mineBehavior != null)
            mineBehavior.lifetime = mineLifetime;
    }
}