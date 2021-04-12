using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public float timeRemaining;
    public float timerMax;
    public Slider slider;


    private void Start()
    {
        timeRemaining = timerMax;
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateSV();
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
        }
        else if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
    }

    float CalculateSV()
    {
        return timeRemaining / timerMax;
    }
}
