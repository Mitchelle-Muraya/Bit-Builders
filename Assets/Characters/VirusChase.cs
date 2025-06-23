using UnityEngine;

public class VirusChase : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;

    void Update()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}

