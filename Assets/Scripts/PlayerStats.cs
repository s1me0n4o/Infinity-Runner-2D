using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private Text scoreUI;

    [SerializeField]
    private Text highScoreUI;

    [SerializeField]
    private Text countScoreUI;

    public static int score = 0;
    public static int highScore;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (score >= highScore)
        {
            highScore = score;
        }

        scoreUI.text = score.ToString();
        highScoreUI.text = highScore.ToString();
        countScoreUI.text = score.ToString();
    }
}
