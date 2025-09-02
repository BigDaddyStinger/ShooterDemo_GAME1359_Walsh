using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class GameManager : MonoBehaviour
{

    [SerializeField] float spawnTime;
    [SerializeField] GameObject enemyShip;
    [SerializeField] private bool gamePlay;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamePlay = true;    
        StartCoroutine(SpawnShip());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnShip()
    {
        while(gamePlay)
        {
            float spawnPosition = Random.Range(-3, 3);
            Instantiate(enemyShip, new Vector3(spawnPosition, 12f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }

    }


}
