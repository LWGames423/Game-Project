using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject playerManager;
    private bool _playerDead = false;
    public bool canDie = true;
    private void FixedUpdate()
    {
        if (_playerDead == true)
        {
            _playerDead = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (canDie)
        {
            Die();    
        }
        
    }

    private void Die()
    {
        playerManager.BroadcastMessage("Death");
        _playerDead = true;
    }
}
