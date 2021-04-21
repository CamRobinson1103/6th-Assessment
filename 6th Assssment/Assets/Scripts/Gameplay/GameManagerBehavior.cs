using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerBehavior : MonoBehaviour
{
    [SerializeField]
    private static bool _gameOver = false;
    [SerializeField]
    private GameObject _gameOverScreen;

    public static bool GameOver
    {
        get
        {
            return _gameOver;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        _gameOverScreen.SetActive(_gameOver);
    }
}
