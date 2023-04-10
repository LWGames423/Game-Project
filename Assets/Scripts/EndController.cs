using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{    
    private bool _redEnter = false;
    private bool _blueEnter = false;

    public float bufferTime = 1.0f;
    private float _bufferTimeTwo = 1.0f;
    private float _bufferTime;
    
    private Animator _anim;

    private void Start()
    {
        _bufferTime = bufferTime;
        _anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("RedPlayer"))
        {
            _redEnter = true;
        } else if (col.CompareTag("BluePlayer"))
        {
            _blueEnter = true;
        }
    }

    private void FixedUpdate()
    {
        if (_redEnter && _blueEnter)
        {
            _bufferTime -= Time.deltaTime;
            if (_bufferTime <= 0)
            {
                BroadcastMessage("End");
                _bufferTimeTwo -= Time.deltaTime;
                if (_bufferTimeTwo <= 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
        else
        {
            _bufferTime = bufferTime;
        }
    }
    
    

    private void End()
    {
        _anim.Play("EndUI", 0, 0);
    }
}


