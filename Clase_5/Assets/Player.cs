using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed=2;
    public int score;
    public float timer;
    public float totalTimePlayed;
    public Vector3 startPoint = new Vector3 (0, -3, 0);

    void Start()
    {
        totalTimePlayed = 0;
        timer = 0;
        score = 0;
        transform.position = startPoint;
    }

    void Update()
    {
        totalTimePlayed += Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {

            transform.position -= transform.right * Time.deltaTime * speed;


        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

        timer += Time.deltaTime;

        if (timer > 1)
        {
            score += 10;
            timer = 0;
        }
    }
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        switch(collision.gameObject.name) {
            case "Enemy":
                Destroy(gameObject);
                int segundosJugados = (int)totalTimePlayed;
                Debug.Log("\nTiempo Jugado: " + segundosJugados + "[s], Puntaje: " + score);
                UnityEditor.EditorApplication.isPlaying = false;
                break;
            case "Obst1":
                score -= 60;
                break;
            case "Obt2":
                score -= 100;
                break;
            case "Obst3":
                score -= 100;
                break;
            case "Points":
                score += 50;
                break;
        }
    }

}
