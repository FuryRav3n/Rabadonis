using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyKill : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(gameObject);
            TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
            t.timeRemaining = t.timeRemaining + 1f;
        }
    }
}
