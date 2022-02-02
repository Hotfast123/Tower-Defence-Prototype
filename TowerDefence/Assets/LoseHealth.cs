using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHealth : MonoBehaviour
{

    public HealthBar playerHealthBar;
    public int maxHealth = 100;
    public int currentHealth = 100;
    public int loseHealthAmount = 20;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        playerHealthBar.SetMaxHealth(maxHealth);
    }

    void OnTriggerEnter(Collider other)
    {
        LostHealth(20);
        Debug.Log("Lost Health");
    }

    void LostHealth(int damage)
    {
        currentHealth -= damage;
        playerHealthBar.SetHealth(currentHealth);
    }

}
