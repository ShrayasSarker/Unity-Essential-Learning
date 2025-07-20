using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Time Settings")]
    [Tooltip("Duration of a full day in seconds.")]
    public float dayDurationInSeconds = 10f; // SUPER FAST cycle

    void Update()
    {
        if (dayDurationInSeconds <= 0)
            return;

        float degreesPerSecond = 360f / dayDurationInSeconds;
        float rotationThisFrame = degreesPerSecond * Time.deltaTime;

        transform.Rotate(Vector3.right * rotationThisFrame);
    }
}

