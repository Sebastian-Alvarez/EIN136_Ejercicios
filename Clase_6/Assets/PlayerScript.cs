using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float x, y;
    public float speed;
    private Rigidbody2D rb;

    public AudioClip[] clips;
    public AudioSource auds;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(x, y) * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        auds.Stop();
        auds.clip = clips[Random.Range(0,clips.Length)];
        auds.Play();
    }
}
