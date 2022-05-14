using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text highscoreText;
    public Text endScoreText;
    public Text endHighscoreText;

    int score = 0;
    int endScore = 0;
    int highscore = 0;
    int endHighscore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        endHighscore = highscore;
        scoreText.text = "Points: " + score.ToString();
        endScoreText.text = "Points: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
        endHighscoreText.text = "Highscore: " + highscore.ToString();
    }

    // Function to Add Points for each diffrent Type of Target + Saving a Highscore
    public void AddPoints(string targetname)
    {
        if (targetname == "Red")
        {
            score += 100;
            scoreText.text = "Points: " + score.ToString();
        }
        if (targetname == "Mint-Green")
        {
            score += 200;
            scoreText.text = "Points: " + score.ToString();
        }
        if (targetname == "Yellow")
        {
            score += 200;
            scoreText.text = "Points: " + score.ToString();
        }
        if (targetname == "Light-Blue")
        {
            score += 300;
            scoreText.text = "Points: " + score.ToString();
        }
        if (targetname == "Blue")
        {
            score += 500;
            scoreText.text = "Points: " + score.ToString();
        }

        if (highscore < score)
        { 
            PlayerPrefs.SetInt("highscore", score);
            endHighscore = highscore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        endScore += score;
        endScoreText.text = "Points: " + score.ToString();
    }
}
