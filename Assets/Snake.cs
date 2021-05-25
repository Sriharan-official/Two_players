using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed = 3f;
    public string inputaxis = "Horizontal";
    public float rotationspeed = 200f;
    float horizontal = 0f;
 
    void Update()
    {
        horizontal = Input.GetAxisRaw(inputaxis);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime,Space.Self);
        transform.Rotate(Vector3.forward * rotationspeed * -horizontal * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "killsplayer")
        {
            speed = 0f;
            rotationspeed = 0f;
            GameObject.FindObjectOfType<Gamemanager>().Endgame();
            
        }
    }

}
