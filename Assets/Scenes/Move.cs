using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : StoryFlag
{
    public float speed = 6.0f;

    public void move(bool up,bool down,bool right,bool left)
    {
        if(up){
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if(down){
            transform.position -= transform.up * speed * Time.deltaTime;
        }
        if(right){
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if(left){
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}