using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;

    private int score = 0;

    void OnEnable()
    {
        Target.OnTargetDestroyed += AddScore;
    }

    void OnDisable()
    {
        Target.OnTargetDestroyed -= AddScore;
    }

    void AddScore()
    {
        score++;

        scoreText.text = "Score: " + score;

        if (score >= 15)
        {
            winText.gameObject.SetActive(true);
        }
    }
}