using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class Strongpass : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI resultText;

    public void ValidateInput()
    {
        string input = inputField.text;

        if (IsValidPassword(input))
        {
            resultText.text = "Your are strong Flag:flag{Your_Great_Defender}";
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "Your are weak";
            resultText.color = Color.red;
        }
    }

    private bool IsValidPassword(string password)
    {
        // Rule: At least 8 characters long
        if (password.Length < 8)
            return false;

        // Rule: Contains at least one uppercase letter
        if (!Regex.IsMatch(password, @"[A-Z]"))
            return false;

        // Rule: Contains at least one lowercase letter
        if (!Regex.IsMatch(password, @"[a-z]"))
            return false;

        // Rule: Contains at least one digit
        if (!Regex.IsMatch(password, @"[0-9]"))
            return false;

        // Rule: Contains at least one special character
        if (!Regex.IsMatch(password, @"[\W_]"))
            return false;

        return true;
    }
}
