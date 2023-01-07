using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int health;
   public int maxHealth = 100;

   public HealthBar hb;

   void act(){
     health = maxHealth;
     hb.setMaxHealth(maxHealth);
   }
   public void damage(int damage){
      health -= damage;
      hb.setHealth(health);
      if (health <= 0){
        Destroy(gameObject);
        GameOver gg = new GameOver();
        gg.gameOver();
      }
   }
}
