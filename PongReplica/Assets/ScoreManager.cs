using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Text leftScoreText;
    public Text rightScoreText;
    private int leftScore = 0;
    private int rightScore = 0;

    public void IncrementScore(string side)
    {
        if (side == "Left")
        {
            leftScore++;
            leftScoreText.text = leftScore.ToString();
        }
        else if (side == "Right")
        {
            rightScore++;
            rightScoreText.text = rightScore.ToString();
        }
    }

    public void ResetScore()
    {
        leftScore = 0;
        rightScore = 0;
        leftScoreText.text = leftScore.ToString();
        rightScoreText.text = rightScore.ToString();
    }
}
