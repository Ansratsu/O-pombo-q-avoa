using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int health = 15;
    public GameObject deathEffect;
    public static bool enemydeath = false;
    public float speed = -10.0f;

    public void TakeDamage (int damage)
    {
        health -= damage;
        
       if (health <= 0)
        {
            enemydeath = true;
            Die();          
        }

    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
		PlayerNumbers.playerScore += 1500;
    }

    void Update()
    {
        
    transform.position = transform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    speed -= speed * 0.01f; 
    if (speed > 0) 
    {
        speed = 0;
    } 

    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Deathsquare"))
        {
            speed = 0;
			
        }     
    }

}

