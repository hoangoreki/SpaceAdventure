using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotApear2 : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border3")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
        else if (collision.tag == "Border4")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Border6")
        {
            Destroy(this.gameObject);
        }
    }
}
