using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMinimap : MonoBehaviour {

    public Transform target = null;
    public bool followTarget = true;
    public float cameraHeight = 18.0f;

    void LateUpdate()
    {
        if (target)
        {
            if (followTarget)
            {
                this.transform.position = new Vector3(target.position.x, cameraHeight, target.position.z);

            }
            else
            {
                this.transform.position = new Vector3(this.target.position.x, cameraHeight, this.target.position.z);
            }

            
        }
    }
}
