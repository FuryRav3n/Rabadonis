using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeControl : MonoBehaviour
{
    public float timeRemaining;
    public float timerMax;
    public Slider slider;
    public GameObject gun;



    private void Start()
    {
        timeRemaining = timerMax;
    }
    // Update is called once per frame
    void Update()
    {
        if (gun.transform.parent != null)
        {
            slider.value = CalculateSV();
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                SceneManager.LoadScene(2);
            }
            else if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
        }
    }

    float CalculateSV()
    {
        return timeRemaining / timerMax;
    }
}
