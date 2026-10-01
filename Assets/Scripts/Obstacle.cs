using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // private GameObject player;

    // Start is called before the first frame update
    // void Start()
    // {
    //     player = GameObject.FindGameObjectWithTag("Player");
    // }
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject); //if obstacle touches border, it will be destroyed (this is done so that obstacle remains in the borders)
        }

        // else if (collision.tag == "Player")
        // {
        //     Destroy(player.gameObject);
        // }
    }
}
