using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerScript : MonoBehaviour
{
  public float speed;

  private Rigidbody2D rb; //simple physics
  private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal1"),Input.GetAxis("Vertical1"));
        //.normalized means you cant move diagonally faster
        velocity = move.normalized * speed;
    }
    //for all code related to adjusting physics
    void FixedUpdate(){
      rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
      //Time.fixedDeltaTime = The interval in seconds at which physics and other fixed frame rate updates (like MonoBehaviour's FixedUpdate) are performed.
    }
}
