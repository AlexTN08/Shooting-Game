using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    public float mouseSensitivity = 3.0f;
    Transform cameraT;
    float verticalLookRotation;

    void Start()
    {
        cameraT = Camera.main.transform;
    }

    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            // rotation
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivity);

            verticalLookRotation += Input.GetAxis("Mouse Y") * mouseSensitivity;
            verticalLookRotation = Mathf.Clamp(verticalLookRotation, -20, 20);

            cameraT.localEulerAngles = Vector3.left * verticalLookRotation;
        }
    }
}
