using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource soundPlay;

    public void OnMouseDown()
    {
        soundPlay.Play();
    }
}
