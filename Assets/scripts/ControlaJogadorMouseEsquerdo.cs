using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogadorMouseEsquerdo : MonoBehaviour {

  public static bool comecou;
  public static bool acabou = false;
  //public static float outOfBoundsLower = -12.0f;
  Rigidbody2D corpoJogador;
  Vector2 forcaImpulso = new Vector2(0, 300);
  public GameObject deathEffect;

  void Start () { 
    corpoJogador = GetComponent<Rigidbody2D> ();
	comecou = false;
  }
  
  void Update () {

	//print(acabou);
    if (Input.GetButtonDown ("Fire1")) { 
    
      if (!comecou) {
        comecou = true;
        corpoJogador.isKinematic = false;
      }

      corpoJogador.velocity = new Vector2 (0, 0);
      corpoJogador.AddForce(forcaImpulso);    
    }
	
	//if(transform.position.y < outOfBoundsLower) acabou = true;
	
	if(acabou)
		Boom();
    
  }
  
  void OnCollisionEnter2D(Collision2D other)
    {
        if(!acabou && other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(Enemy.enemyDamage);
			
        }

        if(other.gameObject.CompareTag("Deathsquare"))
        {
          acabou = true;
        }
                
    }
	
	void Boom()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);            
		gameObject.SetActive(false);
	}
  
  public static void TakeDamage(int damage)
	{
		PlayerNumbers.playerHP -= damage;
		if(PlayerNumbers.playerHP <= 0) acabou = true;
	}
}
