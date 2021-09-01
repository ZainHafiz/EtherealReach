using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthBar;
    public Animator animator;
    public CharacterController2D controller;

    public int maxHealth = 10;
    public int currentHealth;
    public int knockbackAmount = 20;
    public bool isDead;

    void Start()
    {
        if (healthBar == null)
        {
            healthBar = FindObjectOfType<HealthBar>();
        }
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        isDead = currentHealth <= 0;
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.gameObject.CompareTag("Enemy"))
        {
            controller.Move(-1 * Input.GetAxisRaw("Horizontal") * knockbackAmount, false, false);
            TakeDamage(2);

        }
    }

    private void OnCollisionEnter2D(Collision2D instaDeath)
    {
        if (instaDeath.collider.gameObject.CompareTag("InstaDeath"))
        {
            TakeDamage(maxHealth);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        animator.SetTrigger("Hurt");
        if (currentHealth <= 0)
        {
            animator.SetBool("IsDead", true);
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        LevelManager.instance.Respawn();
        healthBar.SetMaxHealth(maxHealth);
    }
}
