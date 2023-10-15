using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
	public static int enemyDamage = 1;
    public GameObject deathEffect;
    public static bool enemydeath = false;


    public void TakeDamage (int damage)
    {
        health -= damage;
        
       if (health <= 0)
        {
            enemydeath = true;
            Die();          
        }

    }
	
	/*void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ControlaJogadorMouseEsquerdo.TakeDamage(enemyDamage);
        }
        //Destroy(gameObject);

    }*/
    

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
		PlayerNumbers.playerScore += 100;
    }

    void Update()
    {
        
    }

}
