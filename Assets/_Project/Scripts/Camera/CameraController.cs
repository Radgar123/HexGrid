using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CameraSetUp),
    typeof(CameraMovement),typeof(CameraInput))]

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;

    private CameraSetUp _setUp;
    private CameraMovement _cameraMovement;
    private CameraInput _cameraInput;
    
    [Header("Camera Movement Param")]
    [SerializeField] private float sensitivity = 10.0f;
    [SerializeField] private float speed = 1.0f;

    private void Awake()
    {
        _setUp = transform.GetComponent<CameraSetUp>();
        _cameraMovement = transform.GetComponent<CameraMovement>();
        _cameraInput = transform.GetComponent<CameraInput>();
    }

    private void Start()
    {
        _setUp.SetCamera(cam);
    }

    private void Update()
    {
        if (_cameraInput.isClick)
        {
            _cameraMovement.Move(sensitivity,speed);
        }
    }
}
