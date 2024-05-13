using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class RaidController : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    private Mosquitos mosquitos;

    void Start()
    {
        score = 0;
        mosquitos = GetComponent<Mosquitos>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && mosquitos.gameTime > 0) 
        {
            Vector3 mousePosi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePosi2D = new Vector2(mousePosi.x, mousePosi.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePosi2D, Vector2.zero);
            if (hit.collider != null)
            {
                Destroy(hit.transform.gameObject);
                score += 1;
                scoreText.text = score.ToString();
                mosquitos.Spawn();
            }
        }


    }
}
