using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  public float speed = 10f;
  public int damage = 50;
  //public GameObject impactEffect;
  public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D info){
      Health pl = info.GetComponent<Health>();
      if(pl!=null){
        pl.damage(damage);
      }
      //Instantiate(impactEffect,transform.position,transform.rotation)
      Destroy(gameObject);

    }


}
