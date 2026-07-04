using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TinniuqPlanetSpawner : MonoBehaviour
{
    public GameObject tinniuqPlanetPrefab;
    public Camera cam;
    public float spawnInterval = 10f;
    public float planetLifetime = 6f;
    public float invincibleDuration = 5f;
    public Text invincibleTimerText;

    void Start()
    {
        StartCoroutine(SpawnPlanetRoutine());
    }

    IEnumerator SpawnPlanetRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnPlanet();
        }
    }

    void SpawnPlanet()
    {
        Vector2 viewportPos = new Vector2(
            Random.Range(0.15f, 0.85f),
            Random.Range(0.15f, 0.85f)
        );
        Vector3 worldPos = cam.ViewportToWorldPoint(viewportPos);
        worldPos.z = 0;

        GameObject planetInstance = Instantiate(tinniuqPlanetPrefab, worldPos, Quaternion.identity);
        TinniuqPlanet tp = planetInstance.GetComponent<TinniuqPlanet>();
        if (tp != null)
        {
            tp.lifetime = planetLifetime;
            tp.invincibleDuration = invincibleDuration;
            tp.invincibleTimerText = invincibleTimerText;
        }
    }
}