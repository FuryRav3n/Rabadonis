using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestruct : MonoBehaviour
{
    public GameObject explosion;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ef = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(ef, 2f);
        Destroy(gameObject);
    }
}
