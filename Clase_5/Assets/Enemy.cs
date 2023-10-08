using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float time2disappear = 3;

    void Start()
    {
        this.name = "Enemy";
        Destroy(GameObject.Find("Enemy"), time2disappear);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);       
    }

}
