using UnityEngine;

public class PlayerMorph : MonoBehaviour
{
    public Sprite zeroSprite;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void MorphToZero()
    {
        sr.sprite = zeroSprite;
    }
}


