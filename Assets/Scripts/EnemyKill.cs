using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyKill : MonoBehaviour
{
    public GameObject Skeleton_Head;
    public GameObject Skeleton_Torso;
    public GameObject Skeleton_Weapon;
    public GameObject Skeleton_LeftLeg;
    public Animator death;
    public ParticleSystem ps;
    private float speed = 5f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            TimeControl t = GameObject.FindWithTag("timebar").GetComponent<TimeControl>();
            t.timeRemaining = t.timeRemaining + 1f;
            death.Play("Base Layer.Dead");
            Destroy(gameObject, 1f);
            //Instantiate(Skeleton_Head, transform.position, transform.rotation);
            //Instantiate(Skeleton_Torso, transform.position, transform.rotation);
            //Instantiate(Skeleton_Weapon, transform.position, transform.rotation);
            //Instantiate(Skeleton_LeftLeg, transform.position, transform.rotation);
            //Skeleton_Head.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            //Skeleton_Torso.GetComponent<Rigidbody2D>().velocity = transform.up * speed;
            //Skeleton_Weapon.GetComponent<Rigidbody2D>().velocity = transform.forward * speed;
            //Skeleton_LeftLeg.GetComponent<Rigidbody2D>().velocity = transform.up * speed;

        }
    }
}
