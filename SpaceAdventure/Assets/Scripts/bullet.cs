using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    
    void Start()
        {
            rb= GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * speed;
        }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
           // GameObject e = Instantiate(explosion) as GameObject;
           // e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if (other.tag == "Border21")
        {
            Destroy(this.gameObject);
        }
        else if (other.tag == "Enemy2")
        {
            // GameObject e = Instantiate(explosion) as GameObject;
            // e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
