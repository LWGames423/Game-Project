using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject playerManager;
    private bool _playerDead = false;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Die();
        }

        if (_playerDead == true)
        {
            _playerDead = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Die();
    }

    public void Die()
    {
        playerManager.BroadcastMessage("Death");
        _playerDead = true;
    }
}
