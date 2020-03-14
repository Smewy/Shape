using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text Score;
    public Text HiScore;


    public static GameMaster GameMaster => new GameMaster();

    public float ScoreCount;
    public float HiScoreCount;
    public float PointsPerSec;

    public bool ScoreIncreasing;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreIncreasing)
        {
            ScoreCount += PointsPerSec * Time.deltaTime;
        }

        if(ScoreCount > HiScoreCount)
        {
            HiScoreCount = ScoreCount;
            PlayerPrefs.SetFloat("HighScore", HiScoreCount);
        }

        Score.text = "Score: " + Mathf.Round (ScoreCount);
        HiScore.text = "High Score: " + Mathf.Round (HiScoreCount);

        if(ScoreCount > 5)
        {
            GameMaster.GoToGameScene2();
        }

    }

    public void AddScore(int pointsToAdd)
    {
        ScoreCount += pointsToAdd;
    }
    
}
