using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class score_manager : MonoBehaviour
{

    public static int score;

    Text scoreText;

	void Awake()
	{
		score = 0;
		scoreText = GetComponent<Text> ();
	}

    void Update()
    {
        updateScore();
    }

    public void scoreIncrease()
    {
        score++;
    }

    public int getScore()
    {
        return score;
    }

    void updateScore()
    {
        scoreText.text = "Score: " + Convert.ToString(score);
    }
}

