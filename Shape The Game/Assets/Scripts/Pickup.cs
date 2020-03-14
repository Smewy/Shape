using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public int ScoreToGive;

    private ScoreManager TheScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        TheScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Triangle")
        {
            TheScoreManager.AddScore(ScoreToGive);
            gameObject.SetActive(false);
        }
    }
}
