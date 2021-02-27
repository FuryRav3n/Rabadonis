using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPickup : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;

    public GameObject Player;

    public AudioSource music;

    public AudioSource loopmusic;

    public GameObject gun;

    private bool pickUpAllowed;

    
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
        music.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.R))
            pickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("Pistacio"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Pistacio"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void pickUp()
    {
            gun.gameObject.transform.position = Player.transform.position;
            gun.gameObject.transform.parent = Player.transform;
            music.Play();
        loopmusic.Stop();
    }
}

