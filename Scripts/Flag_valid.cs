using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlagValid : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;
    [SerializeField] TextMeshProUGUI scoreText; // Reference to the score text on the Scoreboard

    private int score = 0;
    private bool scoreIncreased = false; // Flag to check if the score has already been increased

    public void ValidateInput()
    {
        string input = inputField.text;

        if (input == "flag{Your_Great_Defender}")
        {
            resultText.text = "<b>Congrats</b>";
            resultText.color = Color.yellow;

            if (!scoreIncreased) // Check if the score has already been increased
            {
                IncreaseScore();
                scoreIncreased = true; // Set the flag to true after increasing the score
            }
        }
        else
        {
            resultText.text = "<b>Wrong</b>";
            resultText.color = Color.red;
        }
    }

    private void IncreaseScore()
    {
        score += 38; // Increase the score by 38
        scoreText.text = "Score: " + score.ToString();
    }
}
