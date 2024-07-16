using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerandcollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("You collided");

    }
    private void OnTriggerStay2D(Collider2D collision){
        Debug.Log("you are still colliding");
        
    }
    private void OnTriggerExit2D(Collider2D collision){
        Debug.Log("you are away from stone");
        
    }
}
