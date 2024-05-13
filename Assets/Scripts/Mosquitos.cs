using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mosquitos : MonoBehaviour
{

    public GameObject mosquitosPrefab;
    //public GameObject mosquitosPrefab2;
    public Transform[] spawnPoints;
    public float gameTime = 0f;
    public TMP_Text gameText;
    
    void Start()
    {
        Spawn();
    }

    
    void Update()
    {
        gameTime -= Time.deltaTime;
        if (gameTime < 1f)
        {
            gameTime = 0f;
        }
        gameText.text = gameTime.ToString();
    }

    public void Spawn()
    {
        GameObject mosquito = Instantiate(mosquitosPrefab) as GameObject;
        mosquito.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
    }
}
