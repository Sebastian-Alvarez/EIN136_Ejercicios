using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaker : MonoBehaviour
{
    public AudioSource audio1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Ola");
            audio1.Play();
        }
    }
}
