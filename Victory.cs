using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour {

    public GameObject gameWinUI;
    bool gameIsOver;


    void Start()
    { 
        FindObjectOfType<Player>().OnReachedEndOfLevel += ShowGameWinUI;
    }

    void Update()
    {
        if (gameIsOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void ShowGameWinUI()
    {
        OnGameOver(gameWinUI);
    }

    void OnGameOver(GameObject gameOverUI)
    {
        gameOverUI.SetActive(true);
        gameIsOver = true;
        FindObjectOfType<Player>().OnReachedEndOfLevel -= ShowGameWinUI;
    }
}
