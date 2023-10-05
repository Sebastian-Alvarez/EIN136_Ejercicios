using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound3Script : MonoBehaviour
{
    AudioSource auds3;

    private void Start()
    {
        auds3 = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("played 3");
            auds3.Play();
        }

    }
}
