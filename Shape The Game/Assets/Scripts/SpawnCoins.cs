using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{


    public static RandomPatrol RandomPatrol => new RandomPatrol();


    public GameObject Coin;
    public float RespawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(CoinWave());
    }
    
    private void spawnCoin()
    {
        GameObject a = Instantiate(Coin) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }
  
    IEnumerator CoinWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(RespawnTime);
            spawnCoin();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
