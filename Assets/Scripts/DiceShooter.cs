using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceShooter : MonoBehaviour
{
    public Text HighScore;
    public Text Score;
    int highScore, score;

	void Start ()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        HighScore.text = highScore.ToString();
	}
	
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //Boolean dönüyor
        {
            score = Random.Range(1, 50);
            Score.text = score.ToString();

            if (score>highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
                HighScore.text = highScore.ToString();
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetHighScore();
        }
	}

    void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        //HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); //Ekranda sıfırlıyor fakat arka planda sıfırlamıyor??? önceki high score yi geçmediği sürece sıfır olarak kalıyor.
    }
}
