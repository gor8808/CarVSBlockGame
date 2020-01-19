using UnityEngine;
using UnityEngine.UI;
using System;
public class Score : MonoBehaviour
{
	public Transform Player;
	public Text ScoreText;
    public Text HighScoreText;
    public static int HighScore;
    void Start()
    {
        HighScoreText.text = $"High Score: {HighScore}";
    }
    void Update()
    {
        if(Convert.ToInt32(Player.position.z) >= HighScore)
        {
            HighScore = Convert.ToInt32(Player.position.z);
            HighScoreText.text = $"High Score: {HighScore}";
        }
		ScoreText.text = Player.position.z.ToString("0"); 
    }
}
