using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int ducksInRound = 10;
    public int ducksSpawned = 0;
    public int ducksInGame = 0;
    public int maxDucksInGame = 3;

    public float timeBetweenSpawns = 0.5f;
    public float timer = 0f;

    public GameObject duckPrefab;

    bool lastDuckKilled = true;

    [SerializeField] InputCommands inputCommands;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < timeBetweenSpawns)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0f;
            if(ducksSpawned < ducksInRound && ducksInGame < maxDucksInGame) {
                Instantiate(duckPrefab).GetComponent<DuckAI>().setSpawner(this);
                ducksSpawned++;
                ducksInGame++;
            }
        }
    }

    public void KilledDuck()
    {
        ducksInGame--;
        lastDuckKilled = true;
    }

    public void EscapedDuck()
    {
        if (!lastDuckKilled)
        {
            inputCommands.invertAim();
        }
        lastDuckKilled = false; 
        ducksInGame--;
    }
}
