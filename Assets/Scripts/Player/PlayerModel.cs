using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{

    private int _score;
    private float _moveSpeed = 2f;

    public int Score
    {
        get => _score;
        set => _score = value;
    }
    public float JumpPower
    {
        get => _moveSpeed;
        set => _moveSpeed = value;
    }



}
