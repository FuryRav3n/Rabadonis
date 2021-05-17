using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpeed : MonoBehaviour
{
    float time = 0f;
    public Slider slider;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && time <= 0)
        {
            PlayerPrefs.SetFloat("Speed", 5);
            time = 5f;
        }
        if (time >= 0f)
        {
            time -= Time.deltaTime;
            slider.value = time;
            Debug.Log(time);
            if (time <= 0f)
            {
                time = 0f;
                PlayerPrefs.SetFloat("Speed", 3);
            }
        }
    }
}
