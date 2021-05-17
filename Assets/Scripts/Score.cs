using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text texts;

    void Update()
    {
        texts.text = "Score: " + score;
        PlayerPrefs.SetInt("Score", score);
    }
}
