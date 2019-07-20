using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    
    private GameManager gm;
    private float currentHighScore;

    private void Start()
    {
        currentHighScore = PlayerStats.highScore;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer != 8 && collision.gameObject.layer != 9)
        {
            GameManager.GMInstance.EndGame();
        }
    }
}
