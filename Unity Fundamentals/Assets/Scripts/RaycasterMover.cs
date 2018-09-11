using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycasterMover : MonoBehaviour {

    public Camera camera;
    private Ray ray;
    private RaycastHit hit;
    private GameObject hitObject = null;

    private void Update()
    {
        // Code Purpose: Get Object , Hold Object and Drop Object

        // Get Object
        if (Input.GetMouseButtonDown(0)) {

            ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Cube")
                {
                    hitObject = hit.collider.gameObject;                }
            }

        }

        // Hold Object
        if(hitObject)
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                hitObject.transform.position = new Vector3(hit.point.x, hitObject.transform.position.y, hit.point.z);
            }

            // Drop Object
            if (Input.GetMouseButtonUp(0))
            {
                hitObject = null;
            }

        }

        // Future upgrade adding an Offset to the place the mouse hit instead of the cubes center point. 

    }

}
