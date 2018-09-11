using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour {

    public Transform player = null;
    public Transform target = null;
    public Vector3 speed = new Vector3(5.0f,2.0f,1.0f);
    private Vector3 nextPosition = Vector3.zero;
    public enum CameraState {none, followPosition, lookAtPlayer, both };
    public CameraState cameraState = CameraState.none;

    void LateUpdate()
    {

        //this.transform.position = target.position;

        switch (cameraState) {

            case CameraState.none:
                break;

            case CameraState.followPosition:
                FollowPosition();
                break;
            case CameraState.lookAtPlayer:
                LookAtPlayer();
                break;
            case CameraState.both:
                FollowPosition();
                LookAtPlayer();
                break;
        }

        

    }

    void FollowPosition()
    {
        nextPosition.x = Mathf.Lerp(this.transform.position.x, target.position.x, speed.x * Time.deltaTime);
        nextPosition.y = Mathf.Lerp(this.transform.position.y, target.position.y, speed.y * Time.deltaTime);
        nextPosition.z = Mathf.Lerp(this.transform.position.z, target.position.z, speed.z * Time.deltaTime);
        this.transform.position = nextPosition;
    }

    void LookAtPlayer()
    {
        this.transform.LookAt(player.position);
    }
}
