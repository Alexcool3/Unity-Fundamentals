using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour {

    public Color changedColor = Color.white;
    public Color originalColor = Color.white;

    void Awake()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            enableColor();
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            disableColor();
        }
    }

    public void enableColor()
    {
        GetComponent<Renderer>().material.color = changedColor;
    }

    public void disableColor()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }

}
