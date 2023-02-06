using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour, IMovementable<float>
{
    public void Move(float sensitivity,float speed)
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        transform.position += new Vector3(-mouseX * speed, -mouseY * speed, 0);
    }
}
