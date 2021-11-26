using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{

    public float fullHealth;
    public GameObject deathFX;
    public AudioClip playerHurt;

    public restartGame theGameManager;

    float curentHealth;
   playerController controlMovement;

   public AudioClip playerDeathSound;
    AudioSource playerAS;


    //HUD Variables
   public Slider healthSlider;
    public Image damageScreen;
    public Text gameOverScreen;
    public Text wimGameScreen;

    bool damaged = false;
    Color damagedColour = new Color(0f, 0f, 0f,0.5f);
    float smoothColour = 5f;

    // Start is called before the first frame update
    void Start()
    {
        curentHealth = fullHealth;

        controlMovement = GetComponent<playerController>();

        //HUD Initilzation
       healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;

        damaged = false;

        playerAS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
   {
      if (damaged)
        {
            damageScreen.color = damagedColour;
        }
        else { 
        
           damageScreen.color = Color.Lerp(damageScreen.color, Color.clear,smoothColour*Time.deltaTime);
        }
        damaged = false;
   }
    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        curentHealth -= damage;

        playerAS.clip = playerHurt;
        playerAS.Play();
      //  playerAS.PlayOneShot(playerHurt);

      healthSlider.value = curentHealth;
     damaged = true;
        if (curentHealth <= 0)
        {
            makeDead();
        }
    }
    public void addHealth(float health)
    {
        curentHealth += health;
        if (curentHealth > fullHealth) curentHealth = fullHealth;
        healthSlider.value = curentHealth;
    }
    public void makeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(playerDeathSound, transform.position);
        damageScreen.color = damagedColour;
        Animator gameOverAnimator = gameOverScreen.GetComponent<Animator>();
        gameOverAnimator.SetTrigger("gameOver");
       theGameManager.restartTheGame();
    }

    public void winGame()
    {
       
      Animator winGameAnimator = wimGameScreen.GetComponent<Animator>();
        winGameAnimator.SetTrigger("gameOver");
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
