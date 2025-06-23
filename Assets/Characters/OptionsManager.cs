using UnityEngine;

public class OptionsManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject mainMenuPanel;

    public void OpenOptions() {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void BackToMenu() {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}

