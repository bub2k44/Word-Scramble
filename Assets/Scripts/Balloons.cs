using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startGravity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 1;
        startGravity = rb.gravityScale;
    }
}