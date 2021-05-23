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
    public Animator animator;
    public AudioSource dead;


    private void Start()
    {
        timeRemaining = timerMax;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            timeRemaining = 1;
        }
        if (gun.transform.parent != null)
        {
            slider.value = CalculateSV();
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                dead.Play();
                StartCoroutine(DoAnimation());
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

    IEnumerator DoAnimation()
    {
        animator.Play("Base Layer.deathanim");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);
    }
}
