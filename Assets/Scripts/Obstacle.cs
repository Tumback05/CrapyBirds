using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float speed = 10;
    public GameObject self;

    void Update()
    {
        transform.Translate(Vector2.left * speed);
        Destroy(self, 5f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene("End");
        }
    }

    void OnTriggerEnter2D(Collider2D scr)
    {
        if(scr.transform.CompareTag("Player"))
        {
            UiManagement.score += 1;
        }
    }
}
