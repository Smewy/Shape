﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    
    Vector2 targetPosition;

    public float minSpeed;
    public float maxSpeed;

    float speed;

    public float secondsToMaxDifficulty;

    public GameObject restartPanel;

    public ScoreManager theScoreManager;


    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetrandomPosition();

        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            speed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        } else {
            targetPosition = GetrandomPosition();
        }
    }

    Vector2 GetrandomPosition() {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Planet")
        {
            restartPanel.SetActive(true);

            theScoreManager.ScoreIncreasing = false;

           
        }
    }

    float GetDifficultyPercent() {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
    public void PausePanel()
    {
       
    }
}
