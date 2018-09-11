using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float rotateSpeed = 60.0f;
    public bool canMoveSideways = false;
   

    // Update is called once per frame
    void Update () {

        movement();

        
        


    }

   void movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("Keyboard UpArrow Pressed");
            this.transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (canMoveSideways) {
                this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
            }
            else
            {
                this.transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0));
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (canMoveSideways) { 
            this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
            } else
            {
                this.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0,moveSpeed*Time.deltaTime,0));
        } else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0,-moveSpeed*Time.deltaTime,0));
        }
    }
}
