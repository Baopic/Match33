using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public TMP_Text scoreText;
    public TMP_Text highScore;
    public static float score;
    public int highscore;

    // Use this for initialization
    void Start()
    {
        
    }

    void Update()
    {
        highscore = (int)score;
        scoreText.text = "" + highscore.ToString();
        if(PlayerPrefs.GetInt("score") <= highscore)
        {
            PlayerPrefs.SetInt("score", highscore);

        }
        highScore.text = "" + PlayerPrefs.GetInt("score").ToString();
    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;

    }
}

   