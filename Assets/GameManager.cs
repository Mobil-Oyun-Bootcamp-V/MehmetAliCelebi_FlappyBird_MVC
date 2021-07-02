using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public PlayerView _view;
    private PlayerController _controller;

    private void Start()
    {
        _controller = new PlayerController(_view);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
