using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform cameraTransform;

    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(cameraTransform);
        cameraTransform.rotation = Quaternion.Euler(0, cameraTransform.rotation.eulerAngles.y, 0);
    }
}