using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject player;
    public GameObject gameOverCamera;
    public GameObject healthManager;
    public GameObject buttonPause;

    public int maxHealth = 100;
    public int currentHealth;


    public float invicibilityTimeAfterHit = 3f;
    public float invicibilityFlashDelay = 0.2f;
    public bool isInvincible = false;

    public SpriteRenderer graphics;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        if (!isInvincible)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);

            if (currentHealth <= 0)
            {
                gameOver.SetActive(true);
                player.SetActive(false); 
                gameOverCamera.SetActive(true);
                buttonPause.SetActive(false);
                healthManager.SetActive(false);
                return;
            }

            isInvincible=true;
            StartCoroutine(InvicibilityFlash());
            StartCoroutine(HandleInvicibilityDelay());
        }        
    }

    public IEnumerator InvicibilityFlash()
    {
        while (isInvincible)
        {
            graphics.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(invicibilityFlashDelay);
            graphics.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(invicibilityFlashDelay);

        }
    }

    public IEnumerator HandleInvicibilityDelay()
    {
        yield return new WaitForSeconds(invicibilityTimeAfterHit);
        isInvincible = false;
    }
}
