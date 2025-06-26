using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BitSequencePopup : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text sequenceText;
    public Button continueButton;

    public string[] sequence = { "1", "0", "1", "1" }; // Target sequence
    public BitCollector collector;

    void Start()
    {
        Time.timeScale = 0f; // Pause game
        panel.SetActive(true);
        sequenceText.text = "Collect this bit sequence:\n" + string.Join(" → ", sequence);
        continueButton.onClick.AddListener(HidePopup);

        // Sync targetBits in collector
        if (collector != null)
            collector.targetBits = sequence;
    }

    void HidePopup()
    {
        panel.SetActive(false);
        Time.timeScale = 1f; // Resume game
    }
}
