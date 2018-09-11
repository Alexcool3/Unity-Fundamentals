using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public Camera camera;
    public GameObject obj;
    public Transform origin;
    public float rayLenght = 2.0f;
    private Ray ray;
    private RaycastHit hit;

    private void Update() {

        if (Input.GetMouseButtonDown(0))
        {

            ray = camera.ScreenPointToRay(Input.mousePosition);

            /* Detecting hit object through raycasting
            if (Physics.Raycast(ray)) {

                Debug.Log("Hit Something!");

            }
            */

            /* Instantiating a new object by raycasting on an object via raycasting. 

            if (Physics.Raycast(ray, out hit)) {

                if (hit.collider)
                {
                    Debug.Log("Hit object named " + hit.collider.name);

                    Instantiate(obj, hit.point, hit.transform.rotation);
                }

            }
                  
            */

            /* Raycasting and storing and printing hit objects. 
            RaycastHit[] hits = null;


            hits = Physics.RaycastAll(ray);

            if(hits.Length > 0)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    RaycastHit hit = hits[i];
                    Debug.Log("Hits: " + hit.collider.name);
                }
            }
            */

            RaycastHit[] hits = null;

            hits = Physics.RaycastAll(origin.position, Vector3.forward, rayLenght);

            if (hits.Length > 0)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    Debug.Log("Hits: " + hits[i].collider.name);
                }
                
            }

            Debug.DrawRay(origin.position, Vector3.forward, Color.green, 3);
        }

        //Debug.DrawLine(ray.origin, hit.point, Color.red);
        //Debug.DrawRay(origin.position, Vector3.forward, Color.green, 3);
    }


}
