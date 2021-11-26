using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingRock : MonoBehaviour
{
    public float health;
    private GameObject player, flyingrock;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
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
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Instantiate(flyingrock, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
