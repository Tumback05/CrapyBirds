using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject Obstacle;

    public float cooldownspawn;
    public float nextspawn;

    void Start()
    {
        cooldownspawn = 2;
    }

    void Update()
    {
        if(Time.time > nextspawn)
        {
            Instantiate(Obstacle, new Vector2(20, Random.Range(-10, 14)), Quaternion.identity);
            nextspawn = Time.time + cooldownspawn;
        }
    }
}
