using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    [SerializeField]
    private int score;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    public GameObject gameOverScreen;

    public TMP_Text highScoreLabel;
    public int highScore;
    public SoundEffectsScript soundEffectPlayer;

    [ContextMenu("Aumentar Score")]
    public void addScore(int scoreToAdd)
    {
        score = score + scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if(PlayerPrefs.HasKey("hiScore")) {
            if(score > PlayerPrefs.GetInt("hiScore"))
            {
                highScore = score;
                PlayerPrefs.SetInt("hiScore", highScore);
                PlayerPrefs.Save();
            }
        }
        else
        {   
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("hiScore", highScore);
            PlayerPrefs.Save();
        }
        }
        highScoreLabel.text = "High Score: " + PlayerPrefs.GetInt("hiScore").ToString();
        soundEffectPlayer.playDeathSound();
        gameOverScreen.SetActive(true);
    }
}
