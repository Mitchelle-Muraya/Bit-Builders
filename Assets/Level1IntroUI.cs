using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelIntroUI : MonoBehaviour
{
    public GameObject instructionPanel;
    public TMP_Text instructionText;
    public Button startButton;

    public string[] bitSequence = { "1", "0", "1", "1" };

    void Start()
    {
        instructionPanel.SetActive(true);
        instructionText.text = "Collect this bit sequence:\n" + string.Join(" → ", bitSequence);
        startButton.onClick.AddListener(StartGame);
        Time.timeScale = 0f; // Pause game
    }

    void StartGame()
    {
        instructionPanel.SetActive(false);
        Time.timeScale = 1f; // Resume game
    }
}
