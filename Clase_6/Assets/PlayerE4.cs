using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerE4 : MonoBehaviour
{
    float speed=5f;
    float x, y;

    private void Start()
    {
    }
    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y) * speed*Time.deltaTime;
    }
}

