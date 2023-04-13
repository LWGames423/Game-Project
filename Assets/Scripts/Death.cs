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
        if (_inCollider && !_outTrigger && canDie)
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        _inCollider = true;
        _outTrigger = false;

    }

    private void OnTriggerExit(Collider other)
    {
        _inCollider = false;
        _outTrigger = true;
    }

    private void Die()
    {
        playerManager.BroadcastMessage("Death");
        _inCollider = false;
        _outTrigger = true;
    }
}
