using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    
    public Text endPoints;
    public Text endHighscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        endPoints = FindObjectOfType<ScoreManager>().scoreText;
        endHighscore = FindObjectOfType<ScoreManager>().highscoreText;
    }
}
