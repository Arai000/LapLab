using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandFlag : MonoBehaviour
{
    public bool isArea;

    void OnTriggerStay2D(Collider2D other) 
    {
        if (other.gameObject.name == "VanillaArea") 
        {
            isArea = true;
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.name == "VanillaArea")
        {
            isArea = false;
        }
    }
}