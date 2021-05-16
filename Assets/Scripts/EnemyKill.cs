using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyKill : MonoBehaviour
{
    public Animator death;
    public AudioSource deathSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
            t.timeRemaining = t.timeRemaining + 1f;
            this.GetComponent<Pathfinding.AIPath>().enabled = false;
            death.Play("Base Layer.Dead");
            deathSound.Play();
            Destroy(gameObject, 1f);
        }
        if (collision.gameObject.tag.Equals("pl"))
        {
            TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
            t.timeRemaining = t.timeRemaining - 5f;
            this.GetComponent<Pathfinding.AIPath>().enabled = false;
            death.Play("Base Layer.Dead");
            Destroy(gameObject, 1f);
        }
    }
}
