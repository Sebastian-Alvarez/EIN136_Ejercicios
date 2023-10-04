using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaker : MonoBehaviour
{
    AudioSource auds1;
    AudioSource auds2;
    AudioSource auds3;

    private void Start()
    {
        auds1 = GetComponent<AudioSource>();
        auds2 = GetComponent<AudioSource>();
        auds3 = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("played 1");
            auds1.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Played 2");
            auds2.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Played 3");
            auds3.Play();
        }
    }
}
