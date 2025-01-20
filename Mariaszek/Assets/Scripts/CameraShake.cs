using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance; // Singleton instance for easy access

    [Header("Shake Settings")]
    public float shakeDuration = 0.5f; // Duration of the shake
    public float shakeMagnitude = 0.2f; // Magnitude (strength) of the shake
    public float dampingSpeed = 1.0f; // How quickly the shake dampens

    private Vector3 initialPosition; // Original camera position
    private float currentShakeDuration = 0f; // Remaining shake time

    void Awake()
    {
        // Singleton setup (optional)
        if (Instance == null)
        {
            Debug.Log("Shake init");
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        // Record the initial position of the camera
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if (currentShakeDuration > 0)
        {
            // Apply random shake offset
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            // Decrease the shake duration
            currentShakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            // Reset to the original position once the shake ends
            currentShakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }

    /// <summary>
    /// Triggers the camera shake effect.
    /// </summary>
    /// <param name="duration">Duration of the shake.</param>
    /// <param name="magnitude">Magnitude of the shake.</param>
    public void TriggerShake()
    {
        currentShakeDuration = shakeDuration;
    }
}