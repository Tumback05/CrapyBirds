using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playermovement3 : MonoBehaviour
{
    public float jumpforce = 3f;
    private Rigidbody2D rb;

    public float cooldown;
    private float nextjump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Jump") > 0)
        {
            if (Time.time > nextjump)
            {
                rb.velocity = new Vector2(0, jumpforce);
                nextjump = Time.time + cooldown;
            }
        }
    }
}
