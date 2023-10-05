using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundsKeyboard : MonoBehaviour
{
    public AudioClip ac1;
    public AudioClip ac2;
    public AudioClip ac3;

    public AudioSource source;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
        }
    }
}
