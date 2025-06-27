using UnityEngine;

public class BitMorpher : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;

    public Color colorFor0 = Color.cyan;
    public Color colorFor1 = Color.magenta;

    void Start()
    {
        // 🔍 Try to get Renderer from self or children
        rend = GetComponent<Renderer>();
        if (rend == null)
        {
            rend = GetComponentInChildren<Renderer>();
        }

        if (rend == null)
        {
            Debug.LogError("❌ No Renderer found on this GameObject or its children!");
            return;
        }

        originalColor = rend.material.color;
    }

    public void MorphToBit(string bit)
    {
        if (rend == null) return;

        if (bit == "0")
            rend.material.color = colorFor0;
        else if (bit == "1")
            rend.material.color = colorFor1;
    }

    public void ResetToOriginalColor()
    {
        if (rend != null)
            rend.material.color = originalColor;
    }
}
