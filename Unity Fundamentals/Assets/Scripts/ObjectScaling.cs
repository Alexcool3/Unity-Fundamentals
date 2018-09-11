using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaling : MonoBehaviour {

    public float scaleAmount = 3.0f;
    public Vector3 originalScale = Vector3.zero;

    void Awake()
    {
        originalScale = this.transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            enableScale();
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            disableScale();
        }
    }

    public void enableScale()
    {
        this.transform.localScale = Vector3.one * scaleAmount;
    }

    public void disableScale()
    {
        this.transform.localScale = originalScale;
    }


}
