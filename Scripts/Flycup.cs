using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flycup : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    bool isLeft = true;
    public float speed;
    //***************************************
    public int maxHealth = 100;
    public float currentHealth;
    private float timer = 0;
    private float maxTime = 0.1f;
    public HealthBar healthbar;

    //***************************************
    //public AdsManager ads;

    void Start()
    {
        Audio.UISoundPlay();
        rb = GetComponent<Rigidbody2D>();
        // health //
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        // audio //
    }


    //***************************************
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Jump
            rb.velocity = Vector2.up * velocity;
        }


        if (isLeft == true) // go left if it hits left collider
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (isLeft == false)    // go right if it hits right collider
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (timer > maxTime)
        {
            TakeDamage(0.8f);
            timer = 0;
        }
        timer += Time.deltaTime;

        if (currentHealth <= 0)
        {
            gameManager.GameOver();
            Audio.HealthSoundPlay();
            currentHealth = 100;
            Time.timeScale = 0;
        }
    }
    //***************************************
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "BottomCollider")
        {
            gameManager.GameOver();
            currentHealth = 100;
            Audio.fallSoundPlay();
        }

        if (collision.gameObject.name == "LeftCollider")
        {
            isLeft = false;
        }

        if (collision.gameObject.name == "RightCollider")
        {
            // ? transform.eulerAngles = new Vector3(0, -30, 0);
            isLeft = true;
        }

        if (collision.gameObject.tag == "Orange")
        {
            TakeRecover(5f);
            Score.score++;
            Audio.ItemSoundPlay();
            if (currentHealth > 100)
            {
                currentHealth = 100;
            }
        }
        if (collision.gameObject.tag == "Lemon")
        {
            TakeRecover(10f);
            Score.score++;
            Audio.ItemSoundPlay();
            if (currentHealth > 100)
            {
                currentHealth = 100;
            }
        }
        if (collision.gameObject.tag == "Peach")
        {
            TakeRecover(15f);
            Score.score++;
            Audio.ItemSoundPlay();
            if (currentHealth > 100)
            {
                currentHealth = 100;
            }
        }
        if (collision.gameObject.tag == "Coffee")
        {
            TakeRecover(20f);
            Score.score++;
            Audio.ItemSoundPlay();
            if (currentHealth > 100)
            {
                currentHealth = 100;
            }
        }
        
        if (collision.gameObject.tag == "Rock")
        {
            TakeDamage(10f);
            Audio.RockSoundPlay();
        }
        
        if (collision.gameObject.tag == "FireRock")
        {
            currentHealth = 0;
            gameManager.GameOver();
        }
    }
    //***************************************
    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
    
    void TakeRecover(float recover)
    {
        currentHealth += recover;
        healthbar.SetHealth(currentHealth);
    }
}
