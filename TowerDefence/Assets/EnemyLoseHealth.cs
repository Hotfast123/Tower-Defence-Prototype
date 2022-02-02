using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoseHealth : MonoBehaviour
{
    public HealthBar EHealthBar;
    public int maxHealth = 100;
    public int currentHealth = 100;
    public int loseHealthAmount = 20;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        EHealthBar.SetMaxHealth(maxHealth);
    }

    void OnTriggerEnter(Collider other)
    {
        LostHealth(50);
        if (currentHealth<=0)
        {
            GameObject.FindObjectOfType<Money>().addMoney(5);
            Destroy(gameObject);
        }
    }

    public void LostHealth(int damage)
    {
        currentHealth -= damage;
        EHealthBar.SetHealth(currentHealth);
    }

}
