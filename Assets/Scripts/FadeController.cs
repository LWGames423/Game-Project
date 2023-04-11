using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    private Animator _anim;

    public EndController endController;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (endController.endBool == true)
        {
            _anim.SetBool("End", true);
        }
    }
}
