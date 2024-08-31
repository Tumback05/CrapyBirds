using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathzone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D death)
    {
        if(death.CompareTag("Player"))
        {
            SceneManager.LoadScene("End");
        }
    }
}
