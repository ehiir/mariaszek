using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BillboardEnviro : MonoBehaviour
{
    private Transform cameraTransform;

    void Awake()
    {
        cameraTransform = Camera.main.transform;
    }

    private void OnEnable()
    {
        CinemachineCore.CameraUpdatedEvent.AddListener(OnCameraUpdated);
    }

    private void OnDisable()
    {
        CinemachineCore.CameraUpdatedEvent.RemoveListener(OnCameraUpdated);
    }

    void OnCameraUpdated(CinemachineBrain brain)
    {
        transform.forward = cameraTransform.forward;
    }
}