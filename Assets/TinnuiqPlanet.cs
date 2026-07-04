using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TinniuqPlanet : MonoBehaviour
{
    public float lifetime = 6f;
    public float invincibleDuration = 5f;
    public Text invincibleTimerText;

    void Start()
    {
        StartCoroutine(AutoDestroy());
    }

    void OnTriggerEnter(Collider other)
    {
        playerhelp player = other.GetComponent<playerhelp>();
        if (player != null)
        {
            player.ActivateInvincibility(invincibleDuration, invincibleTimerText);
            Destroy(gameObject);
        }
    }

    IEnumerator AutoDestroy()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}