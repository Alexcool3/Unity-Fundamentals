using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject spawnType = null;
    public float scaleMin = 0.2f;
    public float scaleMax = 2.0f;
    public float force = 100.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(spawnType) as GameObject;

            obj.transform.position = this.transform.position;
            float scaleSize = Random.Range(scaleMin, scaleMax);
            obj.transform.localScale = Vector3.one * scaleSize;
            obj.AddComponent<Rigidbody>();
            obj.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back*force);
            obj.name = "mySphere";

        }
    }

}
