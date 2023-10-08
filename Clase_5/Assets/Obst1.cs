using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obst1 : MonoBehaviour
{
    public float time2Despawn = 3;

    void Start()
    {
        this.name = "Obst1";
        Destroy(GameObject.Find("Obst1"), time2Despawn);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
