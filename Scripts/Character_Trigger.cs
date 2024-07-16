using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Trigger : MonoBehaviour
{
    public GameObject panelObject;  // Reference to the button GameObject

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You collided");
        if (panelObject!= null)
        {
            panelObject.SetActive(true);  // Show the button
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("You are still colliding");
        if (panelObject != null)
        {
            panelObject.SetActive(true);  // Ensure the button remains visible
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("You are away from stone");
        if (panelObject != null)
        {
            panelObject.SetActive(false);  // Hide the button
        }
    }
}
