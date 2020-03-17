using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public ScoreManager theScoreManager;


    public void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }
    public void GoToGameScene() {
        SceneManager.LoadScene("level1");

    }
    public void GoToGameScene2()
    {
        SceneManager.LoadScene("level2");

    }
    public void GoToGameScene3()
    {
        SceneManager.LoadScene("level3");
    }


        public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        theScoreManager.ScoreCount = 0;
        theScoreManager.ScoreIncreasing = true;
    }
    public void GoToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Planet")
        {
            theScoreManager.ScoreIncreasing = false;
        }
    }

    public void info()
    {
        SceneManager.LoadScene("info");
    }
    public void square()
    {
        SceneManager.LoadScene("square");
    }
}