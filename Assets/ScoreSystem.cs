using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static float FinalScore = 0f;

    public Text hudScoreText;

    private float elapsedTime = 0f;
    private bool isRunning = true;

    void Update()
    {
        if (!isRunning) return;
        elapsedTime += Time.deltaTime;
        if (hudScoreText != null)
            hudScoreText.text = "Time: " + Mathf.FloorToInt(elapsedTime) + "s";
    }

    public void StopScore()
    {
        isRunning = false;
        FinalScore = elapsedTime;
    }
}