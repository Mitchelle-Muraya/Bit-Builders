
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MazeScene"); // <- your actual game scene name
    }

    public void OpenOptions()
    {
        Debug.Log("Options Clicked");
        // Optionally show an options panel
    }

    public void ExitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }
}
