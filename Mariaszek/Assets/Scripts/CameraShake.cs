using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance; 

    [Header("Shake Settings")]
    public float shakeDuration = 0.5f; 
    public float shakeMagnitude = 0.2f; 
    public float dampingSpeed = 1.0f; 

    private Vector3 initialPosition; 
    private float currentShakeDuration = 0f; 

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        if (currentShakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            currentShakeDuration -= Time.deltaTime * dampingSpeed;
        }

        else
        {
            currentShakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }

    public void TriggerShake()
    {
        currentShakeDuration = shakeDuration;
    }
}