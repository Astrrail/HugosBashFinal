using UnityEngine;
using UnityEngine.UI;
public class HighScoreManager : MonoBehaviour
{
    public Text Score;
    public Text HighScore;

    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void ScoreCounter()
    {
    


    }
}
