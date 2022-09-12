using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandTalk : MonoBehaviour
{
    private GameObject target;
    public GameObject StandBox;
    public GameObject VanillaTalk;

    void Start ()
    {
        target = GameObject.Find("Hero");
        VanillaTalk = GameObject.Find("talkBoxS");
        StandBox = GameObject.Find("talkBox");
    }
 
    void Update ()
    {
        if(target.GetComponent<Move>().isArea == true) {
            StandBox.GetComponent<Activate>().Active();
        }
        else {
            StandBox.GetComponent<Activate>().Deactive();
        }
    }
}