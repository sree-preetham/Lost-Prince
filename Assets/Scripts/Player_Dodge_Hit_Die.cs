using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Dodge_Hit_Die : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 750;
    public HealthBar healthbar;
    public Animator m_Animator;
    public EnemyController m_Enemy;
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }


    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(20);
            m_Animator.SetTrigger("Hit");
        }*/
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            m_Animator.SetTrigger("Dodge");
        }

    }
    public void takeDamage(int damage)
    {
  
        m_Animator.SetTrigger("Hit");
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
     
       
        if(currentHealth<=0)
        {
            currentHealth = 0;
            die();
        }
        
    }
    public void die()
    {
        m_Animator.SetTrigger("Die");
    }
}

