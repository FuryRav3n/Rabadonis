using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public GameObject projectile;
    public GameObject holder;
    public float speed = 10f;
    public AudioSource shot;


    // Update is called once per frame
    void Update()
    {
        if (transform.IsChildOf(holder.transform))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                shot.Play();
                GameObject p = Instantiate(projectile, transform.position, transform.rotation);
                p.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            }
        }
    }
}
