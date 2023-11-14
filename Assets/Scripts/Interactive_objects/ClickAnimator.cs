using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickAnimator : MonoBehaviour
{
    [Header("Animate")]
    public UnityEvent myEvents;

    private void OnMouseDown()
    {
        myEvents.Invoke();
    }
}
