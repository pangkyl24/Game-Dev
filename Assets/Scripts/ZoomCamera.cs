using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    [SerializeField]
    private float ScrollSpeed = 10;
    private Camera ZoomCam;

    void Start()
    {
        ZoomCam = Camera.main;
    }
    void Update()
    {
        if (ZoomCam.orthographic)
        {
            ZoomCam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        }
        else
        {
            ZoomCam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        }
    }
}
