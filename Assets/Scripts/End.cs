using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public static int scoreend, highscoreend;
    public Text endscore;

    void Start()
    {
        //score system
        scoreend = UiManagement.score;
        highscoreend = UiManagement.highscore;
        endscore = GetComponent<Text>();
        endscore.text = "Your Score: " + scoreend + " Highscore: " + highscoreend;
    }

    void Update()
    {
        //retry
        if(Input.GetKey("return"))
        {
            SceneManager.LoadScene("Level");
            UiManagement.score = 0;
        }
    }
}