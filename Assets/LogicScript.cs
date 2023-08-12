using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField]
    private int score;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    public GameObject gameOverScreen;

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
        soundEffectPlayer.playDeathSound();
        gameOverScreen.SetActive(true);
    }
}
