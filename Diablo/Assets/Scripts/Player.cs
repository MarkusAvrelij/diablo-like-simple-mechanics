using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterStats characterStats;
    public int currentHealth;
    public int maxHealth;
    public int currentLevel;
    public PlayerLevel PlayerLevel { get; set; }

    void Start()
    {
        PlayerLevel = GetComponent<PlayerLevel>();
        this.currentHealth = this.maxHealth;
        characterStats = new CharacterStats(10, 10, 10);
        UIEventHandler.HealthChanged(this.currentHealth, this.maxHealth);
        //UIEventHandler.PlayerLevelChanged(this.PlayerLevel.CurrentExperience, this.PlayerLevel.RequiredExperience);
    }

    public void TakeDamage(int amount)
    {
        Debug.Log("Player takes: " + amount + " damage");
        currentHealth -= amount;
        if (currentHealth <= 0)
            Die();
        UIEventHandler.HealthChanged(this.currentHealth, this.maxHealth);
    }
    private void Die()
    {
        this.currentHealth = this.maxHealth;
        //Destroy(gameObject);
        Debug.Log("Player dead. Reset health");
        UIEventHandler.HealthChanged(this.currentHealth, this.maxHealth);
    }
}
