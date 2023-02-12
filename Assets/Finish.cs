using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool _redEnter = false;
    private bool _blueEnter = false;
    
    private float _bufferTime = 1.0f;
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
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
