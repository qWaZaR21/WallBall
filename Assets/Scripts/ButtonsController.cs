using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseTheGame()
    {
        Time.timeScale = 0;
    }

    public void StartTheGame()
    {
        Time.timeScale = 1;
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
        StartTheGame();
    }
}
