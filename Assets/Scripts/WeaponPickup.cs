using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPickup : MonoBehaviour
{
    public Text pickUpText;

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
        {
            pickUp();
            music.Play();
            loopmusic.Stop();
        }
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
        gun.gameObject.transform.position = new Vector3(Player.transform.position.x + 1, Player.transform.position.y);
        gun.gameObject.transform.parent = Player.transform;
    }
}

