using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public EnemyHealthBar healthBar;
    public int maxHealth = 8;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    { 
    
        
    }

    public void TakeDamage(int damageAmount)
         {
             currentHealth -= damageAmount;
             healthBar.SetHealth(currentHealth);
             Debug.Log("DAMAGE");
             // other stuff you want to happen when enemy takes damage
         }

         
}
