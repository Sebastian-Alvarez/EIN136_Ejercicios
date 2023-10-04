using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    public bool isTemp;
    public float temporizador;

    void Start()
    {
        temporizador = 0;
        isTemp = false;
    }
    void Update()
    {
        if (isTemp == true)
        {
            temporizador += Time.deltaTime;
            if (temporizador >= 3)
            {
                SceneManager.LoadScene("Ejercicio1_esc1");
            }
        }
    }
}
