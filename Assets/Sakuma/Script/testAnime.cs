﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAnime : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if(StageCobtroller .Win)
        {
            animator.SetTrigger("victory");
        }
        else
        {
            animator.SetTrigger("defeat");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
