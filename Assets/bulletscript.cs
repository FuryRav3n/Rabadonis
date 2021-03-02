using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public GameObject projectile;
    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject p = Instantiate(projectile, transform.position, transform.rotation);
            p.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        }
    }
}
