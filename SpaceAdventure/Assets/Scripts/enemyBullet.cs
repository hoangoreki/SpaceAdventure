using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    GameObject target, player;
    public float speed;
    Rigidbody2D bulletRB;
   
    void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bulletRB = GetComponent<Rigidbody2D>();
       target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
       bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
