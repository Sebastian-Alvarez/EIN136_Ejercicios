using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{
    public void Saludar()
    {
        Debug.Log("Hola!");

    }
    public void CambiarEscena()
    {
        SceneManager.LoadScene("Ejercicio2");

    }
}
