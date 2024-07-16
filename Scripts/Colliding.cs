using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerAndCollider : MonoBehaviour
{
    public GameObject passwordPanel; // Assign the Password Panel in the Inspector
    public InputField passwordInput;
    public Button submitButton;
    public GameObject stoneObject;   // Assign the Stone object in the Inspector
    public GameObject doorPrefab;    // Assign the Door prefab in the Inspector
    private string correctPassword = "1234"; // The correct password for the brute force attack

    private void Start()
    {
        // Hide the password panel at the start
        passwordPanel.SetActive(false);

        // Add listener to the button
        submitButton.onClick.AddListener(CheckPassword);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == stoneObject)
        {
            Debug.Log("You collided");
            // Show the password input panel
            passwordPanel.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == stoneObject)
        {
            Debug.Log("You are still colliding");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == stoneObject)
        {
            Debug.Log("You are away from stone");
            // Hide the password input panel
            passwordPanel.SetActive(false);
        }
    }

    private void CheckPassword()
    {
        if (passwordInput.text == correctPassword)
        {
            ChangeStoneToDoor();
        }
        else
        {
            Debug.Log("Incorrect password");
        }
    }

    private void ChangeStoneToDoor()
    {
        // Instantiate the door at the stone's position and rotation
        GameObject door = Instantiate(doorPrefab, stoneObject.transform.position, stoneObject.transform.rotation);

        // Destroy the stone object
        Destroy(stoneObject);

        Debug.Log("Stone changed to Door");

        // Hide the password input panel
        passwordPanel.SetActive(false);
    }
}
