using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTime : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI texto;

    void Start()
    {
        time = 0;
    }
    
    void Update()
    {
        time += Time.deltaTime;

        texto.text = time.ToString("00.0");
    }
}
