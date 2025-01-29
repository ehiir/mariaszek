using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Billboard : MonoBehaviour
{
    private Transform cameraTransform;
    private BoxCollider collider;
    
    private void Awake()
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

    void Start()
    {
        collider = GetComponent<Rigidbody>().GetComponentInChildren<BoxCollider>();
    }

    void FixedUpdate()
    {
        collider.transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
        collider.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void OnCameraUpdated(CinemachineBrain brain)
    {
        transform.forward = cameraTransform.forward;
    }
}