using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text livesText;
    public GameObject gameOverScreen;
    public Spawner spawner;
    public LayerMask shootingLayer;
    public int score;
    public int lives;

    private void Start()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            lives = lives - 1;
            livesText.text = lives.ToString();
            Destroy(other.gameObject);
            if(lives <= 0)
            {
                gameOverScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit = new RaycastHit();
                if(Physics.Raycast(ray, out hit, Mathf.Infinity, shootingLayer))
                {
                    if (hit.collider.CompareTag("Enemy"))
                    {
                        score = score + 1;
                        scoreText.text = score.ToString();
                        Destroy(hit.collider.gameObject);
                    }
                }
            }
        }
    }
}
