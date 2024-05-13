using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mosquitos : MonoBehaviour
{

    public GameObject mosquitosPrefab;
    public Transform[] spawnPoints;
    public float gameTime;
    public Text gameText;
    
    void Start()
    {
        Spawn();
    }

    
    void Update()
    {
        gameTime -= Time.deltaTime;
        if (gameTime < 1)
        {
            gameTime = 0;
        }
        gameText.text = gameTime.ToString();
    }

    void Spawn()
    {
        GameObject mosquito = Instantiate(mosquitosPrefab) as GameObject;
        mosquito.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
    }
}
