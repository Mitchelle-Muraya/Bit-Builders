using UnityEngine;

public class BitMorpher : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;
    public Color colorFor0 = Color.cyan;
    public Color colorFor1 = Color.magenta;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    public void MorphToBit(string bit)
    {
        if (bit == "0")
            rend.material.color = colorFor0;
        else if (bit == "1")
            rend.material.color = colorFor1;
    }

    public void ResetToOriginalColor()
    {
        rend.material.color = originalColor;
    }
}
