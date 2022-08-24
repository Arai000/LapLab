using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryFlag : MonoBehaviour
{
    public GameObject talkBox;
    public int flag = 0;

    public void init()
    {
        talkBox = GameObject.Find("talkBoxS");
        talkBox.GetComponent<Activate>().Deactive();
    }

    public void heroFlag()
    {
        Vector3 tmp = this.transform.position;
        if(tmp.x>8 && tmp.y>8 && flag==0){
            flag = 1;
            talkBox.GetComponent<Activate>().Active();
            Debug.Log("Flagが立った!");
        }
        if(tmp.x<=8 || tmp.y<=8 && flag==1){
            flag = 0;
        }
    }
}
