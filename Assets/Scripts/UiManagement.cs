using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManagement : MonoBehaviour
{
    public static int score = 0;
    public Text scoretxt;

    public static int highscore;

    public Spawning spawner;

    void Start()
    {
        scoretxt = GetComponent<Text>();
        spawner = GetComponent<Spawning>();
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    void Update()
    {
        scoretxt.text = "Score: " + score + " Highscore: " + highscore;
        if(score > highscore)
        {
            highscore = score;
        }

        if(score > 20)
        {
            spawner.cooldownspawn = 1.7f;
        }
        if (score > 30)
        {
            spawner.cooldownspawn = 1.4f;
        }
        if(score > 40)
        {
            spawner.cooldownspawn = 1.1f;
        }
        if(score > 50)
        {
            spawner.cooldownspawn = .8f;
        }
        if(score > 60)
        {
            spawner.cooldownspawn = .5f;
        }

        PlayerPrefs.SetInt("Highscore", highscore);
    }
}
