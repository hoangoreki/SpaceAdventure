using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingame2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerHealth playerWins = other.gameObject.GetComponent<playerHealth>();
           playerWins.winGame();
        }
    }
}
