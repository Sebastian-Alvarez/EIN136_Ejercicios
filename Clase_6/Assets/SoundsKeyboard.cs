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
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            source.Stop();
            source.clip = ac1;
            source.Play();
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            source.Stop();
            source.clip = ac2;
            source.Play();

        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            source.Stop();
            source.clip = ac3;
            source.Play();
        }
    }
}
