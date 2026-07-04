using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class playerhelp : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public ScoreSystem scoreSystem;

    private bool isInvincible = false;
    public bool IsInvincible => isInvincible;

    private Coroutine invincibilityCoroutine;

    public void ActivateInvincibility(float duration, Text timerText)
    {
        if (invincibilityCoroutine != null)
            StopCoroutine(invincibilityCoroutine);
        invincibilityCoroutine = StartCoroutine(InvincibilityTimer(duration, timerText));
    }

    IEnumerator InvincibilityTimer(float duration, Text timerText)
    {
        isInvincible = true;

        if (timerText != null)
            timerText.gameObject.SetActive(true);

        float remaining = duration;
        while (remaining > 0f)
        {
            if (timerText != null)
                timerText.text = "Shield: " + Mathf.CeilToInt(remaining) + "s";
            remaining -= Time.deltaTime;
            yield return null;
        }

        isInvincible = false;
        if (timerText != null)
        {
            timerText.text = "";
            timerText.gameObject.SetActive(false);
        }
    }

    public void crash()
    {
        if (isInvincible) return;   // Block damage while shield is active

        gameObject.SetActive(false);

        if (scoreSystem != null)
            scoreSystem.StopScore();

        if (gameOverText != null)
        {
            Text txt = gameOverText.GetComponent<Text>();
            if (txt != null)
                txt.text = "Your Score: " + Mathf.FloorToInt(ScoreSystem.FinalScore) + "s";
        }

        gameOverText.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
    }
}