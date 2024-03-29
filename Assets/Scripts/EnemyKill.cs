﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;


public class EnemyKill : MonoBehaviour
{
    public Animator death;
    public AudioSource deathSound;
    public AudioSource tookDmg;
    int health = 2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            if(PlayerPrefs.GetString("Difficulty") == "Hard")
            {
                health = health - 1;
                if(health == 0)
                {
                    Score.score += 10;
                    TimeControl ti = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
                    ti.timeRemaining = ti.timeRemaining + 1f;
                    this.GetComponent<Pathfinding.AIPath>().enabled = false;
                    death.Play("Base Layer.Dead");
                    deathSound.Play();
                    Destroy(gameObject, 1f);
                }
            }
            else
            {
                Score.score += 10;
                TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
                t.timeRemaining = t.timeRemaining + 1f;
                this.GetComponent<Pathfinding.AIPath>().enabled = false;
                death.Play("Base Layer.Dead");
                deathSound.Play();
                Destroy(gameObject, 1f);
            }
        }
        if (collision.gameObject.tag.Equals("pl"))
        {
            TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
            t.timeRemaining = t.timeRemaining - 5f;
            tookDmg.Play();
            this.GetComponent<Pathfinding.AIPath>().enabled = false;
            death.Play("Base Layer.Dead");
            Destroy(gameObject, 1f);
        }
    }
}
