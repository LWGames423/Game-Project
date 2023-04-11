using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{    
    [SerializeField]private bool _redEnter = false;
    [SerializeField]private bool _blueEnter = false;

    public float bufferTime = 1.0f;
    private float _bufferTimeTwo = 1.0f;
    private float _bufferTime;

    public bool endBool = false;
    
    private Animator _anim;
    public GameObject end;

    private void Start()
    {
        _anim = end.GetComponent<Animator>();
        _bufferTime = bufferTime;
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

    private void OnTriggerExit2D(Collider2D col)
    {
        _redEnter = false;
        _blueEnter = false;
    }

    private void FixedUpdate()
    {
        if (_redEnter && _blueEnter)
        {
            _bufferTime -= Time.deltaTime;
            if (_bufferTime <= 0)
            {
                endBool = true;
            }
        }
        else
        {
            _bufferTime = bufferTime;
        }
    }
}


