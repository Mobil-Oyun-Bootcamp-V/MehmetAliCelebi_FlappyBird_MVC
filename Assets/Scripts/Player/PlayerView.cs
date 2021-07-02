using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class PlayerView : MonoBehaviour
{

    public UnityAction OnDead;
    public UnityAction UpdateScore;
    public UnityAction Jump;

    public GameObject _restartUi;
    public Text _scoreText;

    public float _jumpPower;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (_restartUi.active == true) return;
        if (Input.GetMouseButtonDown(0))
        {
            Jump?.Invoke();
            _rb.velocity = Vector2.up * _jumpPower;
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        OnDead?.Invoke();
        Time.timeScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        UpdateScore?.Invoke();
    }
}
