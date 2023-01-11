using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerMove PlayerMove => _playerMove;
    public Rigidbody2D Rigidbody => _rigidbody;

    private PlayerMove _playerMove = null;
    private Rigidbody2D _rigidbody = null;


    private void Start()
    {
        Init();
    }

    public void Init()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        _playerMove = gameObject.AddComponent<PlayerMove>();
        _playerMove.Init(this);
    }

    private void Update()
    {
        _playerMove.InputCheck();
    }

}
