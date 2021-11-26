using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winGame : MonoBehaviour
{
    // Start is called before the first frame update

    public Text wimGameScreen;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Animator winGameAnimator = wimGameScreen.GetComponent<Animator>();
            winGameAnimator.SetTrigger("gameOver");
        }
    }
    
    
}
