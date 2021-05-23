using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseUI;
    public GameObject UIcanvas;
    public AudioSource fxSource;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true)
                Resume();
            else Pause();
        }
    }
    public void Resume()
    {

            fxSource.Play(0);
            pauseUI.SetActive(false);
            UIcanvas.SetActive(true);
            Time.timeScale = 1f;
            GameObject.Find("pistol").GetComponent<bulletscript>().enabled = true;
            GameObject.Find("GameObject").GetComponent<acs>().enabled = true;
            GameObject.Find("Pistacio").GetComponent<testcameracontrol>().enabled = true;
            paused = false;
    }
    public void Pause()
    {
        fxSource.Pause();
        pauseUI.SetActive(true);
        UIcanvas.SetActive(false);
        Time.timeScale = 0f;
        GameObject.Find("Pistacio").GetComponent<testcameracontrol>().enabled = false;
        GameObject.Find("GameObject").GetComponent<acs>().enabled = false;
        GameObject.Find("pistol").GetComponent<bulletscript>().enabled = false;
        paused = true;
    }
    public void toMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        pauseUI.SetActive(false);
    }
}
