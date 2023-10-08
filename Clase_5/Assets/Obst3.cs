using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obst3 : MonoBehaviour
{
    public float time2Despawn = 3;

    void Start()
    {
        this.name = "Obst3";
        Destroy(GameObject.Find("Obst3"), time2Despawn);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
