using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button mode;
    public TMP_Text modedif;
    int eas = 0;
    private void Start()
    {
        PlayerPrefs.SetInt("DoubleShotAc", 0);
        if (PlayerPrefs.GetInt("UnlockedHard") == 1)
        {
            mode.gameObject.SetActive(true);
            modedif.gameObject.SetActive(true);
        }
        else PlayerPrefs.SetInt("UnlockedHard", 0);
        if (PlayerPrefs.GetInt("UnlockedAbility") != 1)
        {
            PlayerPrefs.SetInt("UnlockedAbility", 0);
        }
        if(eas == 0)
        {
            PlayerPrefs.SetString("Difficulty", "Easy");
            modedif.text = "Easy";
            eas++;
        }
        if (PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            PlayerPrefs.SetString("Difficulty", "Easy");
            modedif.text = "Easy";
        }
        else
        {
            PlayerPrefs.SetString("Difficulty", "Hard");
            modedif.text = "Hard";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            PlayerPrefs.SetInt("UnlockedHard", 0);
            PlayerPrefs.SetInt("UnlockedAbility", 0);
            PlayerPrefs.SetString("Difficulty", "Easy");
        }
    }
    public void play()
    {
        Score.score = 0;
    }

    public void VisoGero()
    {
        Application.Quit();
    }

    public void ChangeText()
    {
        if(PlayerPrefs.GetString("Difficulty") == "Easy")
        {
            modedif.text = "Hard";
            PlayerPrefs.SetString("Difficulty", "Hard");
        }
        else
        {
            modedif.text = "Easy";
            PlayerPrefs.SetString("Difficulty", "Easy");
        }
    }

    public void resetprogress()
    {
        PlayerPrefs.SetInt("UnlockedHard", 0);
        PlayerPrefs.SetInt("UnlockedAbility", 0);
        PlayerPrefs.SetString("Difficulty", "Easy");
        PlayerPrefs.SetInt("DoubleShotAc", 0);
    }
}
