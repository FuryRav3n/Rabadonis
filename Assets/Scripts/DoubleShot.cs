using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleShot : MonoBehaviour
{
    float time = 0f;
    public Slider slider;
    public Button butt;
    float abt = 0f;

    void Update()
    {
        if (PlayerPrefs.GetString("Difficulty") == "Hard" && PlayerPrefs.GetInt("UnlockedAbility") == 1)
        {
            butt.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && time <= 0)
            {
                PlayerPrefs.SetInt("DoubleShotAc", 1);
                time = 10f;
                abt = 5f;
            }
            if (time >= 0f)
            {
                time -= Time.deltaTime;
                abt -= Time.deltaTime;
                slider.value = time;
                if (abt <= 0f)
                {
                    abt = 0f;
                    PlayerPrefs.SetInt("DoubleShotAc", 0);
                }
                if (time <= 0f)
                {
                    time = 0f;
                }
            }
        }
    }
}
