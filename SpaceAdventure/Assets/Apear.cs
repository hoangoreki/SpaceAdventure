using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apear : MonoBehaviour
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
        else if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Border2")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Border5")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Border6")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Border6")
        {
            Destroy(this.gameObject);
        }
    }
}
