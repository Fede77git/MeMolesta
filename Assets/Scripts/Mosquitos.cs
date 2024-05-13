using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Mosquitos : MonoBehaviour
{
    List<GameObject> mosquitosList = new List<GameObject>();

    public GameObject mosquitosPrefab;
    public GameObject mosquitosPrefab2;
    public GameObject mosquitosPrefab3;

    public Transform[] spawnPoints;
    public float gameTime = 0f;
    public TMP_Text gameText;
    
    void Start()
    {
        mosquitosList.Add(mosquitosPrefab);
        mosquitosList.Add(mosquitosPrefab2);
        mosquitosList.Add(mosquitosPrefab3);

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("mosquitos");

        }
    }

    public void Spawn()
    {
        int prefabIndex = UnityEngine.Random.Range(0, 3);
        GameObject mosquito = Instantiate(mosquitosList[prefabIndex]) as GameObject;

        mosquito.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
    }
}
