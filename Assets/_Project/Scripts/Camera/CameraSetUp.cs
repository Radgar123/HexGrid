using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetUp : MonoBehaviour
{
    public void SetCamera(Camera cam) => cam.transform.position =
        new Vector3(GameManager.instance.cameraPos.x, GameManager.instance.cameraPos.y, transform.position.z);
}
