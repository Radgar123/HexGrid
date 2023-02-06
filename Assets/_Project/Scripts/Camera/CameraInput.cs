using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CameraInput : MonoBehaviour
{
    public InputActionReference rightMouseClick;
    public InputActionReference wheelMouse;
    [HideInInspector] public bool isClick;
    public float wheel;
    public float scrollSpeed;

    private void Start()
    {
        rightMouseClick.action.started += ActivateClick;
        rightMouseClick.action.performed += ActivateClick;
        rightMouseClick.action.canceled += DeactivateOnClick;
        wheelMouse.action.performed += OnWheel;
    }

    private void ActivateClick(InputAction.CallbackContext ctx)
    {
        isClick = true;
    }

    private void DeactivateOnClick(InputAction.CallbackContext ctx)
    {
        isClick = false;
    }

    private void OnWheel(InputAction.CallbackContext ctx)
    {
        wheel = ctx.ReadValue<float>() * scrollSpeed * Time.deltaTime;
    }
    
    
}
