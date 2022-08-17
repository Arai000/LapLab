using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Move
{
    void Start()
    {
        init();
    }

    void Update()
    {
        move(
            Input.GetKey(KeyCode.UpArrow),
            Input.GetKey(KeyCode.DownArrow),
            Input.GetKey(KeyCode.RightArrow),
            Input.GetKey(KeyCode.LeftArrow)
            );
        heroFlag();
    }
}