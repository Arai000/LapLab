using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryFlag : MonoBehaviour
{
    void start(){}
    public int flag = 0;

    public void heroFlag(){
        Vector3 tmp = this.transform.position;
        if(tmp.x>8 && tmp.y>8 && flag==0){
            flag = 1;
            Debug.Log("Flagが立った!");
        }
        if(tmp.x<=8 || tmp.y<=8 && flag==1){
            flag = 0;
        }
    }
}
