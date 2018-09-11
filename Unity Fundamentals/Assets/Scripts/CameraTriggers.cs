using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : MonoBehaviour {

    public Cameras cameras;
    public Cameras.CameraState cameraState;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player" )
        {
            cameras.cameraState = cameraState;
        }
    }
}
