using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    PlayerController _playerController = null;
    float _speed = 5f;

    public void Init(PlayerController playerController)
    {
        _playerController = playerController;
    }


    public void InputCheck()
    {
        Move();
    }

    private void Move()
    {
        Vector2 pos = transform.position;
        Vector2 dir = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            dir.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dir.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir.x += 1;
        }

        // _playerController.Rigidbody.MovePosition((pos + dir) * Time.deltaTime);

        dir = dir.normalized;

        _playerController.Rigidbody.velocity = dir * _speed;
    }


}
