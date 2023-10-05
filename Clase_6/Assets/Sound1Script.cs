using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound1Script : MonoBehaviour
{
    AudioSource auds1;

    private void Start()
    {
        auds1 = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("played 1");
            auds1.Play();
        }

    }
}
