using UnityEngine;

public class BitCollector : MonoBehaviour
{
    public BitMorpher morpher;
    public string[] targetBits = { "1", "1", "0", "1" }; // Example sequence
    private int currentIndex = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bit0") || other.CompareTag("Bit1"))
        {
            string collected = other.CompareTag("Bit0") ? "0" : "1";

            if (collected == targetBits[currentIndex])
            {
                morpher.MorphToBit(collected);
                currentIndex++;
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("Wrong Bit Collected!");
                // Optional: knockback or flash red
            }
        }
    }
}
