using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
  private float walk = 0.8f;
  private float run = 1.5f;
  private float jumpPower = 2.0f;
  private Vector2 movev;
  private Rigidbody2D rb;

  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && !(rb.velocity.y < -0.5f)){
      Jump();
    }
    if(Input.GetKey(KeyCode.LeftShift)){
      Debug.Log(Input.GetAxis("Horizontal"));
      Debug.Log("test");
      rb.velocity = new Vector2(Input.GetAxis("Horizontal") * run, rb.velocity.y);
    }else{
      rb.velocity = new Vector2(Input.GetAxis("Horizontal") * walk, rb.velocity.y);
    }
    
    positionLimit();
  }

  void positionLimit() {
    Vector2 pos = rb.position;
    if(pos.x<-3){
      rb.position=new Vector2(-3.0f,pos.y);
    }
    if(pos.x>3){
      rb.position=new Vector2(3.0f,pos.y);
    }
  }

  void Jump() {
    rb.AddForce(transform.up * jumpPower, ForceMode2D.Impulse);
  }
}