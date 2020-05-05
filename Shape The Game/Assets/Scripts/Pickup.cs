using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public int ScoreToGive;

    private ScoreManager theScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (theScoreManager.ScoreIncreasing == false)
        {
            ScoreToGive = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Triangle")
        {
            theScoreManager.AddScore(ScoreToGive);
            gameObject.SetActive(false);
        }
    }
}
