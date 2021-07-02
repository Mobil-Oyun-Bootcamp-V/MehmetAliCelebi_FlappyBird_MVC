using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerView _view;
    private PlayerModel _model;

    public PlayerController(PlayerView view)
    {
        _view = view;
        _view.OnDead = PlayerDead;
        _view.UpdateScore = UpdateScore;
        _view.Jump = Jump;

        _model = new PlayerModel();
    }

    private void PlayerDead()
    {
        _view._restartUi.SetActive(true);
    }

    private void UpdateScore()
    {
        _model.Score++;
        _view._scoreText.text = _model.Score + "";
    }
    private void Jump()
    {
        _view._jumpPower = _model.JumpPower;
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
}

