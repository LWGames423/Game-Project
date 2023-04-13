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

    private bool _inCollider = false;
    private bool _outTrigger = true;
    private void FixedUpdate()
    {
        if (_inCollider && canDie)
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        _inCollider = true;

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        _inCollider = false;
    }

    private void Die()
    {
        playerManager.BroadcastMessage("Death");
        _inCollider = false;
    }
}
