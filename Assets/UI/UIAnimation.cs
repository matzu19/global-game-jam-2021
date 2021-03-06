﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour
{
    public GameObject gameLogo;
    public GameObject introText;
    public TimerCountdown timerCountdown;
    private bool start;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.anyKeyDown && !start)
        {
            gameLogo.GetComponent<Image>().CrossFadeAlpha(0, (float)1.5, false);
            introText.GetComponent<Text>().CrossFadeAlpha(0, 1, false);
            timerCountdown.takingAway = false;
            start = true;
        }
    }
}
