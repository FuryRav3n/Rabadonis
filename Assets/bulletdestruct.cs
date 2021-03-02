using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestruct : MonoBehaviour
{
    public GameObject explosion;
    void OnCollisionEnter2D()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
