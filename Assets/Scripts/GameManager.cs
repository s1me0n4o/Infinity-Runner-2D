using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GMInstance;

    [SerializeField]
    private GameObject background;

    private void Awake()
    {
        GMInstance = this;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        MoveLeft.endGame = false;
    }

    public void EndGame()
    {
        MoveLeft.endGame = true;
        background.SetActive(true);
    }
}
