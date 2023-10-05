using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound2Script : MonoBehaviour
{
    AudioSource auds2;

    private void Start()
    {
        auds2 = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("played 2");
            auds2.Play();
        }

    }
}
