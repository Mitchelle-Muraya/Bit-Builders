using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Image img;

    void Start() {
        img = GetComponent<Image>();
    }

    public void ChangeToRandomColor() {
        img.color = new Color(Random.value, Random.value, Random.value);
    }
}
