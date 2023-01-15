using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public bool isLever = false;
    public bool interactableDown = false;
    public bool flippedStatus = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (flippedStatus)
        {
            interactableDown = false;
        }
        else if (!flippedStatus)
        {
            interactableDown = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (isLever)
        {
            if (flippedStatus)
            {
                interactableDown = false;
            }
            else if (!flippedStatus)
            {
                interactableDown = true;
            }
        }
        else
        {
            if (flippedStatus)
            {
                interactableDown = true;
            }
            else if (!flippedStatus)
            {
                interactableDown = false;
            }
        }
    }
}
