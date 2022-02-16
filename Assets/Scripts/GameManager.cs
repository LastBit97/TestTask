using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private Button restartButton;

    private int score;

    private void OnEnable()
    {
        PlayerController.onTouched += UpdateScore;
        PlayerController.onTouched += GameOver;
    }

    private void OnDisable()
    {
        PlayerController.onTouched -= UpdateScore;
        PlayerController.onTouched -= GameOver;
    }

    private void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void GameOver()
    {
        if (score >= 5)
        {
            restartButton.gameObject.SetActive(true);
        }
    }
}
