using UnityEngine;

public class Bit : MonoBehaviour
{
    public bool isCorrectBit = false; // true = 0bit, false = 1bit

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isCorrectBit)
            {
                Debug.Log("✅ Correct bit collected!");
                other.GetComponent<PlayerMorph>().MorphToZero();
            }
            else
            {
                Debug.Log("❌ Wrong bit!");
                // Optional: Push bit away, reduce score etc.
            }

            Destroy(gameObject); // Remove bit after collection
        }
    }
}
