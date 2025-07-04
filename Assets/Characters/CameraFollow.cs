using UnityEngine;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Assign your Player here
    public Vector3 offset = new Vector3(0, 5, -7);
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(target);
    }
}
