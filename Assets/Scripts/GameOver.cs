using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TMP_Text hardmode;
    public GameObject ability;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Score") >= 200 && PlayerPrefs.GetInt("UnlockedHard") != 1)
        {
            hardmode.gameObject.SetActive(true);
            PlayerPrefs.SetInt("UnlockedHard", 1);
        }
        if (PlayerPrefs.GetString("Difficulty") == "Hard" && PlayerPrefs.GetInt("Score") >= 200 && PlayerPrefs.GetInt("UnlockedAbility") != 1)
        {
            ability.SetActive(true);
            PlayerPrefs.SetInt("UnlockedAbility", 1);
        }
    }
    // Start is called before the first frame update
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
