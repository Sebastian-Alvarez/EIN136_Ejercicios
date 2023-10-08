using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obst2 : MonoBehaviour
{
    public float time2Despawn = 3;

    void Start()
    {
        this.name = "Obst2";
        Destroy(GameObject.Find("Obst2"), time2Despawn);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
