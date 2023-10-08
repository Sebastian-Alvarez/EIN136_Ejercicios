using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public float time2DespawnPoints = 3;

    void Start()
    {
        this.name = "Points";
        Destroy(GameObject.Find("Points"), time2DespawnPoints);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);    
    }
}
