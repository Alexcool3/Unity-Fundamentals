using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnClick : MonoBehaviour {

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("cubeMove");
        }
    }



}
