using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;
    public bool isGameOver = false;
    [ContextMenu("Increse Score")]
    public void addScore(int? scoreToAdd)
    {
        Debug.Log("Score before increment: " + playerScore);
        //if scoreToAdd is not null then add scoreToAdd to playerScore
        //else add 1 to playerScore
        if (!isGameOver)
        {
            if (scoreToAdd != null )
            {
                playerScore += scoreToAdd.Value;
                scoreSFX.Play();
            }
            else
            {
                playerScore++;
                scoreSFX.Play();
            }
        }        
        
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }
    //how to stop add score when game over
    //how to stop pipe from spawning when game over
    public void quiteGame()
    {
        Application.Quit();
    }
}
